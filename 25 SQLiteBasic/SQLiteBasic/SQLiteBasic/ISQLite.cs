using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteBasic
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
