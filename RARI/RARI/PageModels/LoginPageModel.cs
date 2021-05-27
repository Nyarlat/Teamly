using RARI.Services;
using RARI.Services.Account;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RARI.PageModels
{
    public class LoginPageModel: PageModelBase
    {
        private ICommand _loginCommand;
        public ICommand LoginCommand
        {
            get => _loginCommand;
            set => SetProperty(ref _loginCommand, value);
        }

        private ICommand _regCommand;
        public ICommand RegCommand
        {
            get => _regCommand;
            set => SetProperty(ref _regCommand, value);
        }

        private string _username;

        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        private string _password;

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        private INavigationService _navigationService;
        private IAccountService _accountService;

        public LoginPageModel(INavigationService navigationService, IAccountService accountService) 
        {
            _navigationService = navigationService;
            _accountService = accountService;

            // инициализация команд
            LoginCommand = new Command(DoLoginAction);
            RegCommand = new Command(DoRegAction);
        }

        private async void DoLoginAction()
        {
            var loginAttempt = //true;
                await _accountService.LoginAsync(Username, Password);
            if (loginAttempt)
            {
                // отправка на страницу пользователя
                await _navigationService.NavigateToAsync<PersonProfilePageModel>();
            }
            else
            {
                // уведомление об ошибке
            }

        }

        private async void DoRegAction(object obj)
        {
            await _navigationService.NavigateToAsync<RegPage1Model>();
        }

    }
}
