using AutoMapper;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XFSWDemo.Model;
using XFSWDemo.Service;

namespace XFSWDemo.ViewModels
{
    public class PlanetsPageViewModel : BaseViewModel
    {
        public Task Initialization { get; private set; }

        public PlanetsPageViewModel()
        {
            RefreshCommand = new Command(async () => await GetPlanets());

            Initialization = GetPlanets();
        }

        private ObservableCollection<PlanetViewModel> planets;
        private ICommand refreshCommand;

        public ObservableCollection<PlanetViewModel> Planets
        {
            get { return planets; }
            set { if (planets == value) return; planets = value; OnPropertyChanged(nameof(Planets)); }
        }
        public ICommand RefreshCommand
        {
            get { return refreshCommand; }
            set { if (refreshCommand == value) return; refreshCommand = value; OnPropertyChanged(nameof(RefreshCommand)); }
        }

        private async Task GetPlanets()
        {
            IsBusy = true;

            try
            {
                var service = new BaseService<Planet>("planets/", string.Empty);

                var planetList = await service.Get();

                var config = new MapperConfiguration(cfg => cfg.CreateMap<Planet, PlanetViewModel>());
                var mapper = new Mapper(config);

                Planets = new ObservableCollection<PlanetViewModel>();

                foreach (var item in planetList)
                {
                    Planets.Add(mapper.DefaultContext.Mapper.Map<PlanetViewModel>(item));
                }
            }
            catch (Exception)
            {

                var notificationService = DependencyService.Get<INotificationService>();
                notificationService.Notify("No se pudieron obtener los datos.");
            }

            IsBusy = false;
        }
    }
}
