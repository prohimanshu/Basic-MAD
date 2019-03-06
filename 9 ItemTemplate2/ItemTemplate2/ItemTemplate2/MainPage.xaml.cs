using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ItemTemplate2
{
    public partial class MainPage : ContentPage
    {
        public List<Data> people = new List<Data>()
        {
            new Data{Name="Himanshu",Address="HN03,Utail Dehradun,248158",Images="abcd.jpg"},
            new Data{Name="Rahul",Address="Pori Uttarakhand",Images="abcd.jpg"},
            new Data{Name="Mohit",Address="Vikasnagar Dehradun",Images="abcd.jpg"}
        };
        public MainPage()
        {
            InitializeComponent();
            Mylist.ItemsSource = people;
        }
    }
}
