using RARI.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RARI.PageModels
{
    public class SearchPageModel : PageModelBase
    {
        public override Task InitializeAsync(object navigationData = null)
        {
            return base.InitializeAsync(navigationData);
        }

        private INavigationService _navigationService;
        public SearchPageModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            // инициализация команд
            GoToSearch = new Command(GoToSearchAction);
            GoToMessenger = new Command(GoToMessengerAction);
            GoToTeam = new Command(GoToTeamAction);
            GoToPerson = new Command(GoToPersonAction);
        }

        private ICommand _goToSearch;
        public ICommand GoToSearch
        {
            get => _goToSearch;
            set => SetProperty(ref _goToSearch, value);
        }

        private async void GoToSearchAction(object obj)
        {
            await _navigationService.NavigateToAsync<SearchPageModel>();
        }

        private ICommand _goToMessenger;
        public ICommand GoToMessenger
        {
            get => _goToMessenger;
            set => SetProperty(ref _goToMessenger, value);
        }

        private async void GoToMessengerAction(object obj)
        {
            await _navigationService.NavigateToAsync<MessengerPageModel>();
        }

        private ICommand _goToPerson;
        public ICommand GoToPerson
        {
            get => _goToPerson;
            set => SetProperty(ref _goToPerson, value);
        }

        private async void GoToPersonAction(object obj)
        {
            await _navigationService.NavigateToAsync<PersonProfilePageModel>();
        }

        private ICommand _goToTeam;
        public ICommand GoToTeam
        {
            get => _goToTeam;
            set => SetProperty(ref _goToTeam, value);
        }

        private async void GoToTeamAction(object obj)
        {
            await _navigationService.NavigateToAsync<TeamProfilePageModel>();
        }

    }
}
