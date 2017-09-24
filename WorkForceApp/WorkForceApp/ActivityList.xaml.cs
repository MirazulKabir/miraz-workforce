using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkForceApp.Database;
using WorkForceApp.Model;
using WorkForceApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkForceApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityList : ContentPage
    {
        int i = 0;
        private SQLiteAsyncConnection _connection;
        Tasks task;
        public ActivityList()
        {
            InitializeComponent();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();

            task = new Tasks { name = "Colect money", outletName = "Cats Eye Outlet", startTime = "10:14", endTime = "Dhanmondi 3A" };

            BindingContext = task;
            OutletDetails.StartButtonClicked += BtnClicked;

            //outletDetails.btnClicked();
            // listView.ItemsSource = taskLists;
        }

        protected override async void OnAppearing()
        {
            await _connection.CreateTableAsync<Tasks>();
            var tasks = await _connection.Table<Tasks>().ToListAsync();
           
            await _connection.InsertAsync(task);
            base.OnAppearing();
        }

        public void BtnClicked(object source, EventArgs e)
        {
            lbl_login_info.Text = "Clicked " + i;
            i++;

            // DisplayAlert("Btn clicked", "WOW using Delicate", "Ok");
            // Console.WriteLine("asdkash");
        }




    }
}