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
using SQLiteBasic.Droid;
using Xamarin.Forms;

[assembly:Dependency(typeof(SQLite_Droid))]
namespace SQLiteBasic.Droid
{
    public class SQLite_Droid : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var dbName = "mydatabase.sqlite";
            var dbPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(dbPath, dbName);
            var conn = new SQLiteConnection(path);
            return conn;
        }
    }
}