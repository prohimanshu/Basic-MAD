using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteBasic2
{
    public interface ISQLiteInterface
    {
        SQLiteConnection GetConnectionWithDatabase();

        bool SaveEmployee(string name, string address, string phonenumber, string email, string password);
    }
}
