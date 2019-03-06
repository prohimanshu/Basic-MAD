using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using SQLiteBasic2.Droid;
using Xamarin.Forms;

[assembly:Dependency(typeof(SQLite_Android))]
namespace SQLiteBasic2.Droid
{
    public class SQLite_Android : ISQLiteInterface
    {
        SQLiteConnection database;

        public SQLiteConnection GetConnectionWithDatabase()
        {
            string filename = "sampledatabse.db3";
            string documentpath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            string path = Path.Combine(documentpath, filename);

            database = new SQLiteConnection(path);

            database.CreateTable<Employee>();

            return database;
        }

        public bool SaveEmployee(string name, string address, string phonenumber, string email, string password)
        {
            bool flag = false;
            try
            {
                Employee employee = new Employee();
                employee.Name = name;
                employee.Address = address;
                employee.PhoneNumber = phonenumber;
                employee.Email = email;
                employee.Password = password;

                database.Insert(employee);
                flag = true;
            }
            catch(Exception ex)
            {
                flag = false;
            }
            return flag;
        }
    }
}