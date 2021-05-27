using RARI.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RARI.PageModels
{
    public class RegPage1Model: PageModelBase
    {
        private INavigationService _navigationService;
        public RegPage1Model(INavigationService navigationService)
        {
            _navigationService = navigationService;

            // инициализация команд
            GoToReg2 = new Command(GoToReg2Action);
        }

        private ICommand _goToReg2;
        public ICommand GoToReg2
        {
            get => _goToReg2;
            set => SetProperty(ref _goToReg2, value);
        }

        private async void GoToReg2Action(object obj)
        {
            await _navigationService.NavigateToAsync<RegPage2Model>();
        }
    }
}
