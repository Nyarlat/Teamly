using RARI.PageModels;
using RARI.Services;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RARI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        Task InitNavigation()
        {
            var navService = PageModelLocator.Resolve<INavigationService>();
            return navService.NavigateToAsync<LoginPageModel>();
        }

        protected override async void OnStart()
        {
            base.OnStart();
            await InitNavigation();
            base.OnResume();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
