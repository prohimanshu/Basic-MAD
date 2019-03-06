using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Getdata(object sender, EventArgs e)
        {
            var url ="http://"+urlEntry.Text;
            Browser.Source = url;
        }
    }
}
