using RARI.PageModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RARI.ViewModels.ToChat
{
    public class ToChatViewModel
    {
        public ObservableCollection<ToChatModel> ToChatDetails { get; set; }
        public ToChatViewModel()
        {
            ToChatDetails = new ObservableCollection<ToChatModel>()
            {
                new ToChatModel (){ id = 0, SearchName="Кашапов Руслан" , SearchDetails="АХАХАХАХАХАХАХАХАХАХА " },
                new ToChatModel(){ id = 1 , SearchName="Игнатишина Виктория" , SearchDetails="Ребят,никто не хочет выпить сегодня?Кто в Уфе разумеется."},
                new ToChatModel(){id = 2 , SearchName="Данил Тимофеев" , SearchDetails="Можешь скинуть отчет по ТРПО? "}

            };
        }
    }
}
