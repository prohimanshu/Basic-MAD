using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SQLiteBasic2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SaveEmployee(object sender, EventArgs e)
        {
            string name = EmployeeName.Text;
            string address = Address.Text;
            string phonenumber = PhoneNumber.Text;
            string email = Email.Text;
            string password = Password.Text;

            bool response = DependencyService.Get<ISQLiteInterface>().SaveEmployee(name, address, phonenumber, email, password);
            if (response)
            {
                DisplayAlert("Message", "Data Successfully saved", "Ok");
            }
            else
            {
                DisplayAlert("Message", "Data not saved", "Ok");
            }
        }
    }
}
