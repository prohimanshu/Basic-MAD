using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MakePhoneCall
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MakeCall(object sender, EventArgs e)
        {
            DependencyService.Get<IPhoneCall>().makecall(NumberEntry.Text.ToString());
        }
    }
}
