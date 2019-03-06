using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PopupsDisplay
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ClickHear(object sender, EventArgs e)
        {
            var response =await DisplayAlert("Message", "Do you want to change Color(Green)", "Ok", "No");
            if (response)
            {
                this.BackgroundColor = Color.Green;
            }
            else
            {
                this.BackgroundColor = Color.White;
            }
        }
    }
}
