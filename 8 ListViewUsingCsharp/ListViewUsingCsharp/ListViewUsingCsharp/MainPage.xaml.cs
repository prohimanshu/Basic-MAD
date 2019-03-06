using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewUsingCsharp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            var mylist = new ListView();
            mylist.ItemsSource = new List<string>
            {
                "Apple","Banana","Gavava","Orange","Mango"
            };
            Content = mylist;
        }
    }
}
