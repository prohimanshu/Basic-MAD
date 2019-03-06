using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginPage
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //InitializeComponent();
            this.BackgroundColor = Color.FromHex("#2ccbff");
            var userLabel = new Label { Text = "Username", TextColor = Color.Black };
            var userentry = new Entry { Placeholder = "Username" };
            var passLabel = new Label { Text = "Password", TextColor = Color.Black };
            var passentry = new Entry { Placeholder = "Password", IsPassword = true };
            var loginbutton = new Button { Text = "Login", BackgroundColor = Color.White, TextColor = Color.FromHex("2ccbff") };
            var regLabel = new Label { Text = "Not a Member? Sign up now", TextColor = Color.Gray, HorizontalOptions = LayoutOptions.Center };
            loginbutton.Clicked += LoginEvent;
            this.Content = new StackLayout
            {
                Padding = new Thickness(20),
                Margin = new Thickness(0, 80, 0, 0),
                Children =
                {
                    userLabel,userentry,passLabel,passentry,loginbutton
                }
            };
        }

        private void LoginEvent(object sender, EventArgs e)
        {
            DisplayAlert("Login", "Login Sucessfull", "Ok");
        }
    }
}

