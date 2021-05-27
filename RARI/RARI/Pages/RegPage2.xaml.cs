using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RARI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegPage2 : ContentPage
    {
        //FirebaseHelper firebaseHelper = new FirebaseHelper();
        public RegPage2()
        {
            InitializeComponent();
        }

        //private async void bReg2_Clicked(object sender, EventArgs e)
        //{
        //    string lang = "none";
        //    switch (lang)
        //    {
        //        case "C#":
        //            if (Langs1.IsChecked) lang = "C#";
        //            break;
        //        case "C/C++":
        //            if (Langs2.IsChecked) lang = "C/C++";
        //            break;
        //        case "Java":
        //            if (Langs3.IsChecked) lang = "Java";
        //            break;
        //        case "PHP":
        //            if (Langs4.IsChecked) lang = "PHP";
        //            break;
        //        default: break;
        //    }

        //    await firebaseHelper.AddPerson2(FirstName.Text, SecondName.Text, City.Text, lang);
        //    FirstName.Text = string.Empty;
        //    SecondName.Text = string.Empty;
        //    City.Text = string.Empty;
        //}
    }
}