using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ItemTemplate
{
    public partial class MainPage : ContentPage
    {
        public List<Data> people = new List<Data>()
        {
            new Data{Name="Himanshu",Address="Dehradun"},
            new Data{Name="Mohit",Address="Pori"},
            new Data{Name="Hari",Address="USA"}
        };
        public MainPage()
        {
            InitializeComponent();
            mylist.ItemsSource = people;
        }
    }
}
