using RARI.Pages;
using RARI.Services;
using RARI.Services.Account;
using RARI.Services.Navigation;
using RARI.TinyIoC;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RARI.PageModels
{
    public class PageModelLocator
    {
        static TinyIoCContainer _container;
        static Dictionary<Type, Type> _viewLookup;

        static PageModelLocator()
        {
            _container = new TinyIoCContainer();
            _viewLookup = new Dictionary<Type, Type>();

            // Создание страниц и моделей страниц
            Register<DashboardModel, DashboardPage>();
            Register<LoginPageModel, LoginPage>();
            Register<MessengerPageModel, MessengerPage>();
            Register<PersonProfilePageModel, PersonProfile>();
            Register<RegPage1Model, RegPage1>();
            Register<RegPage2Model, RegPage2>();
            Register<SearchPageModel, SearchPage>();
            Register<TeamProfilePageModel, TeamProfile>();


            // Сервисы регистрации ( сервисы создаются с помощью паттерны "Одиночка" по умолчанию)
            _container.Register<INavigationService, NavigationService>();
            _container.Register<IAccountService>(DependencyService.Get<IAccountService>());
        }

        public static T Resolve<T>() where T: class
        {
            return _container.Resolve<T>();
        }

        public static Page CreatePageFor(Type pageModelType)
        {
            var pageType = _viewLookup[pageModelType];
            var page = (Page)Activator.CreateInstance(pageType);
            var pageModel = _container.Resolve(pageModelType);
            page.BindingContext = pageModel;
            return page;
        }

        static void Register<TPageModel, TPage>() where TPageModel : PageModelBase where TPage : Page
        {
            _viewLookup.Add(typeof(TPageModel), typeof(TPage));
            _container.Register<TPageModel>();
        }
    }
}
