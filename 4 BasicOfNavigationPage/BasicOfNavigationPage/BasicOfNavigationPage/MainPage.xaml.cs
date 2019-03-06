using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BasicOfNavigationPage
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void LoginEvent(object sender, EventArgs e)
        {
            DisplayAlert("Login", "Login Sucessfull", "Ok");
            Navigation.PushAsync(new HomePage(usernameentry.Text));
        }
    }
}
