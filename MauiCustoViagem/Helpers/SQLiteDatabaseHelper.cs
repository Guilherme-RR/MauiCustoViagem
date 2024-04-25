using MauiCustoViagem.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCustoViagem.Helpers
{
    public class SQLiteDatabaseHelper
    {
       readonly SQLiteConnection _conn;
       public SQLiteDatabaseHelper(string path)
        {
            _conn = new SQLiteConnection(path);
            _conn.CreateTable<Pedagio>().ToString();
        }

        
    }
}
