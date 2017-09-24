using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using WorkForceApp.Database;
using WorkForceApp.Droid.Database;

[assembly: Dependency(typeof(SQLiteDb))]
namespace WorkForceApp.Droid.Database
{
    class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentPath, "MySQLite.db3");
            return new SQLiteAsyncConnection(path);
        }
    }
}