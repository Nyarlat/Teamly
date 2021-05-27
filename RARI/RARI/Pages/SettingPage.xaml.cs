using RARI.ViewModels.SettingsViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RARI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingPage : ContentPage
    {
        public SettingPage()
        {
            InitializeComponent();
            BindingContext = new SettingsViewModel();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItemIndex == 0)
            {
                //Navigation.PushModalAsync(new ChangeProfile());
            }
            if (e.SelectedItemIndex == 1)
            {

            }
            if (e.SelectedItemIndex == 2)
            {
                //Navigation.PushModalAsync(new Help());
            }
            if (e.SelectedItemIndex == 3)
            {
                //Navigation.PushModalAsync(new ChangePassword());
            }
        }
    }
}