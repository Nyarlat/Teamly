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
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
            string[] phones = new string[] { code, city, category, sex };
            ListSearch.ItemsSource = phones;
        }

        private void SetList(string code, string city, string category, string sex)
        {
            string[] phones = new string[] { code, city, category, sex };
            ListSearch.ItemsSource = phones;
        }

        string code = "Язык программирования: ";
        string city = "Город: ";
        string category = "Категория: ";
        string sex = "Пол: ";


        private async void ListSearch_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItemIndex == 0)
            {
                string buf;
                buf = await DisplayActionSheet("Языки программирования ", "Отмена", "Очистить", "C++ ", "Java ", "Python ");
                if (buf == "Очистить")
                {
                    code = "Языки программирования: ";
                }
                else
                {
                    code += buf;
                }
                SetList(code, city, category, sex);
            }
            if (e.SelectedItemIndex == 1)
            {
                string buf;
                buf = await DisplayPromptAsync("Выбор города", "Введите ваш город");
                if (buf == "Cancel")
                {
                    city = "Город: ";
                }
                else
                {
                    city += buf;
                }
                SetList(code, city, category, sex);
            }
            if (e.SelectedItemIndex == 2)
            {
                string buf;
                buf = await DisplayActionSheet("Категория", "Отмена", "Очистить", "Разработка игр ", "Разработка ПО ", "Создание сайтов ");
                if (buf == "Очистить")
                {
                    category = "Категория: ";
                }
                else
                {
                    category += buf;
                }
                SetList(code, city, category, sex);
            }
            if (e.SelectedItemIndex == 3)
            {
                string buf;
                buf = await DisplayActionSheet("Пол", "Отмена", "Очистить", "Мужчина ", "Женщина ", "Другое ");
                if (buf == "Очистить")
                {
                    sex = "Пол: ";
                }
                else
                {
                    sex += buf;
                }
                SetList(code, city, category, sex);
            }
        }
    }
}