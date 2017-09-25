using SQLite;
using System.Collections.Generic;
using WorkForceApp.Model;
using Xamarin.Forms;

namespace WorkForceApp.Database
{


    class DbHandler
    {
        private SQLiteAsyncConnection _connection;
        public static DbHandler _dbHandlerInstance = new DbHandler();

        public DbHandler()
        {
            // _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            // CreateTables();
        }

        public static DbHandler Instance()
        {
            if (_dbHandlerInstance == null)
                _dbHandlerInstance = new DbHandler();

            return _dbHandlerInstance;
        }

        public void ConnectDb()
        {
            if (_connection == null)
            {
                _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            }



        }

        public SQLiteAsyncConnection GetConnection()
        {
            if (_connection == null)
            {
                return _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            }
            else return _connection;

        }

        public async void CreateTables()
        {
            await _connection.CreateTableAsync<User>();
            await _connection.CreateTableAsync<UserPosition>();
            await _connection.CreateTableAsync<TaskType>();
            await _connection.CreateTableAsync<AppointmentClass>();
            await _connection.CreateTableAsync<ActivityClass>();

        }

        public async void InsertData<T>(IEnumerable<T> obj)
        {
            //await _connection.InsertAsync(obj);
            await _connection.InsertAllAsync(obj);
            //var query = _connection.Table<User>().Where(v => v.name.StartsWith("A"));
            // var query2 = _connection.Table<User>();




        }



    }

}

