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
            InitializeComponent();
        }


        private void LoginBtn(object sender, EventArgs e)
        {
            DisplayAlert("Login", "Login Sucessfull", "Ok");
                        //hedder //for show string //button text
        }
    }
}
