using RARI.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RARI.PageModels
{
    public class RegPage2Model : PageModelBase
    {
        private INavigationService _navigationService;
        public RegPage2Model(INavigationService navigationService)
        {
            _navigationService = navigationService;

            // инициализация команд
            GoToPerson = new Command(GoToPersonAction);
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
    }
}
