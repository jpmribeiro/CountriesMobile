using Prism;
using Prism.Ioc;
using Countries.Prism.ViewModels;
using Countries.Prism.Views;
using Xamarin.Essentials.Interfaces;
using Xamarin.Essentials.Implementation;
using Xamarin.Forms;
using Countries.Prism.Services;
using Syncfusion.Licensing;

namespace Countries.Prism
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            SyncfusionLicenseProvider.RegisterLicense("MzU4MjIyQDMxMzgyZTMzMmUzMFZwaG81ZTlTME4yenVKbXdlZ1MyS2hQYlFINGdYZ0tnZ0FxeUM4ZVorcTA9");
            InitializeComponent();
            await NavigationService.NavigateAsync("NavigationPage/CountriesPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            containerRegistry.Register<IApiService, ApiService>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<CountriesPage, CountriesPageViewModel>();
            containerRegistry.RegisterForNavigation<CountryDetails, CountryDetailsViewModel>();
        }
    }
}
