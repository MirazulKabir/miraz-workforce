using System;
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

        AppointmentClass task;
        public ActivityList()
        {
            InitializeComponent();



            BindingContext = task;
            OutletDetails.StartButtonClicked += BtnClicked;

            //outletDetails.btnClicked();
            // listView.ItemsSource = taskLists;
        }

        protected override async void OnAppearing()
        {
            DbHandler.Instance().ConnectDb();
            DbHandler.Instance().CreateTables();

            JsonHandler._jsonInstance.MyJsonParser();
            // DbHandler dbHandler = new DbHandler();
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