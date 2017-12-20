using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFSWDemo.ViewModels;

namespace XFSWDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlanetsPage : ContentPage
    {
        PlanetsPageViewModel ViewModel;

        public PlanetsPage()
        {
            InitializeComponent();

            ViewModel = new PlanetsPageViewModel();
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