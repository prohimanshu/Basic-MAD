using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GridListView
{
    public partial class MainPage : ContentPage
    {
        public List<Data> people = new List<Data>()
        {
            new Data{Name="Himanshu", Address="Dehradun",ID=1},
            new Data{Name="Rahul",Address="Delhi",ID=2},
            new Data{Name="Mohit",Address="Kalsi",ID=3}
        };
        public MainPage()
        {
            InitializeComponent();
            Mylist.ItemsSource = people;
        }
    }
}
