using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFSWDemo.ViewModels;

namespace XFSWDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StarShipsPage : ContentPage
    {
        StarShipsPageViewModel ViewModel;

        public StarShipsPage()
        {
            InitializeComponent();

            ViewModel = new StarShipsPageViewModel();
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