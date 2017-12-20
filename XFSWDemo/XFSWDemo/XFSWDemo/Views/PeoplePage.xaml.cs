using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFSWDemo.ViewModels;

namespace XFSWDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PeoplePage : ContentPage
    {
        PeoplePageViewModel ViewModel;

        public PeoplePage()
        {
            InitializeComponent();

            ViewModel = new PeoplePageViewModel();
            BindingContext = ViewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await ViewModel.Initialization;
        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}