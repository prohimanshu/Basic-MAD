using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AbsoluteLout2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var layout = new AbsoluteLayout();

            var box1 = new BoxView() { BackgroundColor = Color.FromHex("#73a2ef") };
            AbsoluteLayout.SetLayoutBounds(box1, new Rectangle(0, 0, 1, 0.3));
            AbsoluteLayout.SetLayoutFlags(box1, AbsoluteLayoutFlags.All);

            var box2 = new BoxView() { BackgroundColor = Color.FromHex("#6bd0d6") };
            AbsoluteLayout.SetLayoutBounds(box2, new Rectangle(0, 1, 1, 0.7));
            AbsoluteLayout.SetLayoutFlags(box2, AbsoluteLayoutFlags.All);

            var box3 = new BoxView() { BackgroundColor = Color.White };
            AbsoluteLayout.SetLayoutBounds(box3, new Rectangle(0.5, 0.2, 100, 100));
            AbsoluteLayout.SetLayoutFlags(box3, AbsoluteLayoutFlags.PositionProportional);

            layout.Children.Add(box1);
            layout.Children.Add(box2);
            layout.Children.Add(box3);
            Content = layout;
        }
    }
}
