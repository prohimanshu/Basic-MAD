using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TabbedPageCsharp
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            //InitializeComponent();
            var ContentPage1 = new ContentPage
            {
                Title = "Page1",
                Content = new StackLayout
                {
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        new Label
                        {
                            Text="Tabbed Page 1"
                        }
                    }
                }
            };
            var ContentPage2 = new ContentPage
            {
                Title = "Page1",
                Content = new StackLayout
                {
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        new Label
                        {
                            Text="Tabbed Page 2"
                        }
                    }
                }
            };
            Children.Add(ContentPage1);
            Children.Add(ContentPage2);
        }
    }
}
