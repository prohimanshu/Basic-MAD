using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ToastMsg
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var message = "This is Long Time Message";
            DependencyService.Get<IMessage>().Longtime(message);
            //DependencyService.Get<IMessage>().Shorttime(message);
        }
    }
}
