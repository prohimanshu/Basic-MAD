using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PickersUsingCsharp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();//start call App.xaml

            var dataList = new List<string>();//list for location
            dataList.Add("INDIA");
            dataList.Add("USA");
            dataList.Add("UK");
            dataList.Add("Srilanka");

            this.BackgroundColor = Color.FromHex("#2bcbff");//back color

            var headerlabel = new Label { Text = "Picker", FontSize = 20, HorizontalOptions = LayoutOptions.Center };//create label

            var dp = new DatePicker();//create date picker
            {
                dp.MinimumDate = DateTime.Now;//set min Date
            }

            var tp = new TimePicker();//create time picker

            var datapicker = new Picker();//create data picker
            {
                datapicker.Title = "Select Location";
            }

            datapicker.ItemsSource = dataList;//data include in datapicker

            var submitbutton = new Button()//create button
            {
                Text = "Show Details",
                BackgroundColor = Color.White,
                TextColor = Color.FromHex("#2bcbff")
            };
            var detailslabel = new Label//create label for result
            {

            };

            submitbutton.Clicked += showdetails;//create function for button

            void showdetails(object sender, EventArgs e)//create show result function
            {
                var getdate = dp.Date;
                var gettime = tp.Time;
                var getpickerdata = datapicker.SelectedItem;
                detailslabel.Text = string.Format("Date:{0} \n Time:{1} \n Location:{2}", getdate, gettime, getpickerdata);
            }
            this.Content = new StackLayout//create stack layout and include all event
            {
                Padding = new Thickness(20),
                Children ={
                    headerlabel,dp,tp,datapicker,submitbutton,detailslabel
                }
            };
        }
    }
}
