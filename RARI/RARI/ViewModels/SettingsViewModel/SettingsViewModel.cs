using RARI.PageModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RARI.ViewModels.SettingsViewModel
{
    public class SettingsViewModel
    {
        public ObservableCollection<SettingPageModel> MySettings { get; set; }
        public SettingsViewModel()
        {
            MySettings = new ObservableCollection<SettingPageModel>()
            {
                new SettingPageModel (){  HomeName="Редактировать профиль"  },
                new SettingPageModel(){  HomeName="Настройки чатов" },
                new SettingPageModel(){ HomeName="Помощь" },
                new SettingPageModel(){ HomeName="Сменить пароль" }
            };
        }
    }
}
