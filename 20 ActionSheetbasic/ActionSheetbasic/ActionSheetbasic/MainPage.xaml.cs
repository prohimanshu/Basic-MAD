using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ActionSheetbasic
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ClickedAction(object sender, EventArgs e)
        {
            var action=await DisplayActionSheet("Select Country", "Cancel","", "India", "USA", "UK", "Australia");
            if(action== "India")
            {
                ActionDetils.Text = "Select Country" + action;
            }
            if (action == "USA")
            {
                ActionDetils.Text = "Select Country" + action;
            }
            if (action == "UK")
            {
                ActionDetils.Text = "Select Country" + action;
            }
            if (action == "Australia")
            {
                ActionDetils.Text = "Select Country" + action;
            }
        }
    }
}
