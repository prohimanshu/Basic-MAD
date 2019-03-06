using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InternetConnt
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Getdata(object sender, EventArgs e)
        {
            CheckConnectivity();
            var url = "http://" + urlEntry.Text;
            Browser.Source = url;
        }

        private void CheckConnectivity()
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                DisplayAlert("Message", "Internet Connected", "Ok");
            }
            else
            {
                DisplayAlert("Message", "No Internet Connection", "Ok");
            }
        }
    
    }
}
