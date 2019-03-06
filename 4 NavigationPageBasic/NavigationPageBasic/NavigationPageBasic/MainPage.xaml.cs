using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationPageBasic
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void LoginEvent(object sender, EventArgs e)
        {
            DisplayAlert("Login", "Login Sucessfull", "Ok");
            Navigation.PushAsync(new HomePage());
        }
    }
}
