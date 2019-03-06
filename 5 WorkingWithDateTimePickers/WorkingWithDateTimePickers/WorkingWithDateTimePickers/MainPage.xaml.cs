using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WorkingWithDateTimePickers
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Buttn_Clicked(object sender, EventArgs e)
        {
            var date = dp.Date;
            var time = tp.Time;
            details.Text = string.Format("Date:{0} \n Time:{1}", date, time);

        }

    }
}
