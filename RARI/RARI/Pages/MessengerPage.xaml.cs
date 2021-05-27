using RARI.ViewModels.ToChat;
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
    public partial class MessengerPage : ContentPage
    {
        public MessengerPage()
        {
            InitializeComponent();
            BindingContext = new ToChatViewModel();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DisplayActionSheet("Категория", "Отмена", "Очистить", "Разработка игр ", "Разработка ПО ", "Создание сайтов ");
        }
    }
}