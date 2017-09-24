using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using System.IO;
using WorkForceApp.iOS.Database;
using Xamarin.Forms;
using WorkForceApp.iOS;
using WorkForceApp.Database;
using SQLite;

[assembly: Dependency(typeof(SQLiteDb))]
namespace WorkForceApp.iOS.Database
{
    class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentPath,"MySQLite.db3");

            return new SQLiteAsyncConnection(path);
        }

    }
}