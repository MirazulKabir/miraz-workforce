using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace WorkForceApp.Database
{
   public  interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
