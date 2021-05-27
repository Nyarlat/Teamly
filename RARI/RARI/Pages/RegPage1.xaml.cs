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
    public partial class RegPage1 : ContentPage
    {
        //FirebaseHelper firebaseHelper = new FirebaseHelper();
        public RegPage1()
        {
            InitializeComponent();
        }


        //private async void bReg1_Clicked(object sender, EventArgs e)
        //{
        //    await firebaseHelper.AddPerson1(RegLogin.Text, RegPass.Text);
        //    RegLogin.Text = string.Empty;
        //    RegPass.Text = string.Empty;

        //    await Navigation.PushModalAsync(new RegPage2());
        //}
    }
}