using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        public ActivityList()
        {

            InitializeComponent();

            Tasks task = new Tasks { name = "Colect money", outletName = "Cats Eye Outlet", startTime = "10:14", endTime = "Dhanmondi 3A" };

            BindingContext = task;
            OutletDetails.StartButtonClicked += BtnClicked;

            //outletDetails.btnClicked();
            // listView.ItemsSource = taskLists;
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