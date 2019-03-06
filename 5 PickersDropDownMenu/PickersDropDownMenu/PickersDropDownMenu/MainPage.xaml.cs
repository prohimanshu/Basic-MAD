using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PickersDropDownMenu
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
            var pickerdata = MyPicker.SelectedItem.ToString();
            details.Text = string.Format("Date:{0} \n Time:{1} \n Location:{2}", date, time, pickerdata);

        }
    }
}
