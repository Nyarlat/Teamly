using RARI.PageModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace RARI.ViewModels.Buttons
{
    class ButtonModel : ExtendedBindableObject
    {
        string _text;
        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        bool _isvisible;
        public bool IsVisible
        {
            get => _isvisible;
            set => SetProperty(ref _isvisible, value);
        }

        bool _isEnable;
        public bool IsEnabled
        {
            get => _isEnable;
            set => SetProperty(ref _isEnable, value);
        }

        ICommand _command;
        public ICommand Command
        {
            get => _command;
            set => SetProperty(ref _command, value);
        }

        public ButtonModel(string title, ICommand command, bool isVisible = true, bool isEnabled = true)
        {
            Text = title;
            Command = command;
            IsVisible = isVisible;
            IsEnabled = isEnabled;
        }
    }
}
