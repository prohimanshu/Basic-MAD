using SQLite;
using SQLiteBasic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SQLiteBasic
{
    public partial class MainPage : ContentPage
    {
        private SQLiteConnection conn;
        public Student student;
        public MainPage()
        {
            InitializeComponent();
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Student>();
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            student = new Student();
            student.Name = Name.Text;
            student.Address = Address.Text;
            conn.Insert(student);
            Name.Text = "";
            Address.Text = "";
        }

        private void ShowButton_Clicked(object sender, EventArgs e)
        {
            var data = (from stu in conn.Table<Student>() select stu);
            Datalist.ItemsSource = data;
        }
    }
}
