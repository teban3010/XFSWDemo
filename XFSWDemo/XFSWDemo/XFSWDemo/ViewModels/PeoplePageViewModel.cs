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
    public class PeoplePageViewModel : BaseViewModel
    {
        public Task Initialization { get; private set; }

        public PeoplePageViewModel()
        {
            RefreshCommand = new Command(async () => await GetPeople());

            Initialization = GetPeople();
        }

        private ObservableCollection<PeopleViewModel> people;
        private ICommand refreshCommand;

        public ObservableCollection<PeopleViewModel> People
        {
            get { return people; }
            set { if (people == value) return; people = value; OnPropertyChanged(nameof(People)); }
        }
        public ICommand RefreshCommand
        {
            get { return refreshCommand; }
            set { if (refreshCommand == value) return; refreshCommand = value; OnPropertyChanged(nameof(RefreshCommand)); }
        }

        private async Task GetPeople()
        {
            IsBusy = true;

            try
            {
                var service = new BaseService<People>("people/", string.Empty);

                var peopleList = await service.Get();

                var config = new MapperConfiguration(cfg => cfg.CreateMap<People, PeopleViewModel>());
                var mapper = new Mapper(config);

                People = new ObservableCollection<PeopleViewModel>();

                foreach (var item in peopleList)
                {
                    People.Add(mapper.DefaultContext.Mapper.Map<PeopleViewModel>(item));
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