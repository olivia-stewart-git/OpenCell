using AnimationApp.AnimationEditor.Views;
using AnimationApp.Builder;
using AnimationApp.Service.Navigation;

namespace AnimationApp
{
    public partial class MainPage : ContentPage
    {
        readonly INavigationService _navigationService;
        public MainPage()
        {
            InitializeComponent();
            _navigationService = ServiceHelper.GetService<INavigationService>();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            _navigationService.Navigate(nameof(EditorPage));
        }
    }
}