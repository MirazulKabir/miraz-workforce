using System;
using Xamarin.Forms;

namespace WorkForceApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            //  JsonHandler._jsonInstance.MyJsonParser();

        }

        private async void btn_Login_Clicked(object sender, EventArgs e)
        {
            if (IsUserValid())
            {
                await Navigation.PushAsync(new UsersActivityList());
            }
            // DisplayAlert("Pass", ": "+pass + " Id :" + phone, "OK");
        }

        private bool IsUserValid()
        {
            // string phone = phone_entry.Text;
            //  string pass = password_entry.Text;
            return true;
        }
    }
}
