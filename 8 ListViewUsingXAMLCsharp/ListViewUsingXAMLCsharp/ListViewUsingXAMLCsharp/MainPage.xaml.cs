using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewUsingXAMLCsharp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            mylist.ItemsSource = new List<string>
            {
                "Apple","Orange","Banana","Gavava"
            };
        }
    }
}
