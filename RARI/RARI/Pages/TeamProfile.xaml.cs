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
    public partial class TeamProfile : ContentPage
    {
        public TeamProfile()
        {
            InitializeComponent();
            CreateComand1.Source = "https://sun9-62.userapi.com/impg/fKZQasRCeg6disZzNnsBaZ9sRWrugst9oJqIPA/oDZ7IOUw_Fg.jpg?size=800x800&quality=96&sign=eb3e5e26e8425faeda99881223c72f39&type=album";
        }

 
    }
}