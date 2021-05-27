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
    public partial class ChatPage : ContentPage
    {
        public ChatPage()
        {
            InitializeComponent();
        }

        public int cout = 0;

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            cout++;
            ScrollView scroll_view = new ScrollView();
            scroll_view.VerticalOptions = LayoutOptions.EndAndExpand;
            scroll_view.HorizontalOptions = LayoutOptions.EndAndExpand;
            scroll_view.VerticalScrollBarVisibility = ScrollBarVisibility.Never;
            scroll_view.Content = stack_layout;
            grid.Children.Add(scroll_view);

            if (Message_Enty.Text.Length == 0)
            {
                Message_Enty.Placeholder = " Введите сообщение";
            }
            else
            {


                if (Message_Enty.Text.Length < 10)
                {
                    Frame frame1 = new Frame
                    {
                        Padding = 0,
                        CornerRadius = 20,
                        WidthRequest = 100,
                        HorizontalOptions = LayoutOptions.EndAndExpand,
                        Content = new Label
                        {
                            Padding = new Thickness(0, 0, 0, 0),
                            Text = Message_Enty.Text,
                            HorizontalTextAlignment = TextAlignment.Center,
                            VerticalTextAlignment = TextAlignment.Center,
                            HeightRequest = 60,
                            WidthRequest = 100,
                            HorizontalOptions = LayoutOptions.EndAndExpand,
                            VerticalOptions = LayoutOptions.FillAndExpand,
                            BackgroundColor = Color.FromHex("E9CAFF")
                        }
                    };
                    stack_layout.Children.Add(frame1);
                    scroll_view.ScrollToAsync(0, cout * 60, false);
                }
                else
                {
                    Frame frame2 = new Frame
                    {
                        Padding = 0,
                        CornerRadius = 20,
                        WidthRequest = Message_Enty.Text.Length * 10,
                        HorizontalOptions = LayoutOptions.EndAndExpand,
                        Content = new Label
                        {
                            Padding = new Thickness(0, 0, 0, 0),
                            Text = Message_Enty.Text,
                            HorizontalTextAlignment = TextAlignment.Center,
                            VerticalTextAlignment = TextAlignment.Center,
                            HeightRequest = 60,
                            WidthRequest = Message_Enty.Text.Length * 10,
                            HorizontalOptions = LayoutOptions.EndAndExpand,
                            VerticalOptions = LayoutOptions.FillAndExpand,
                            BackgroundColor = Color.FromHex("E9CAFF")
                        }
                    };
                    stack_layout.Children.Add(frame2);
                    scroll_view.ScrollToAsync(0, cout * 60, false);
                }
            }
        }  
    }
}