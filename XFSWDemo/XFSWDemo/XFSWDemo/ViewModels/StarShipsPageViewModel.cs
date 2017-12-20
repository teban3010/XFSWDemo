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
    public class StarShipsPageViewModel : BaseViewModel
    {
        public Task Initialization { get; private set; }

        public StarShipsPageViewModel()
        {
            RefreshCommand = new Command(async () => await GetStarShips());

            Initialization = GetStarShips();
        }

        private ObservableCollection<StarShipViewModel> starShips;
        private ICommand refreshCommand;

        public ObservableCollection<StarShipViewModel> StarShips
        {
            get { return starShips; }
            set { if (starShips == value) return; starShips = value; OnPropertyChanged(nameof(StarShips)); }
        }
        public ICommand RefreshCommand
        {
            get { return refreshCommand; }
            set { if (refreshCommand == value) return; refreshCommand = value; OnPropertyChanged(nameof(RefreshCommand)); }
        }

        private async Task GetStarShips()
        {
            IsBusy = true;

            try
            {
                var service = new BaseService<StarShip>("starships/", string.Empty);

                var starShipList = await service.Get();

                var config = new MapperConfiguration(cfg => cfg.CreateMap<StarShip, StarShipViewModel>());
                var mapper = new Mapper(config);

                StarShips = new ObservableCollection<StarShipViewModel>();

                foreach (var item in starShipList)
                {
                    StarShips.Add(mapper.DefaultContext.Mapper.Map<StarShipViewModel>(item));
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
