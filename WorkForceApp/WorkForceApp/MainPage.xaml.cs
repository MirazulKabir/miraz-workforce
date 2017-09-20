using Plugin.Media;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WorkForceApp
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();           
            JsonHandler._jsonInstance.MyJsonParser();

        }

        private async Task TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsPickPhotoSupported)
            {
                DisplayAlert("No Picker", ": No Picker available.", "OK");
                return;
            }

            var file = await CrossMedia.Current.PickPhotoAsync();
            if (file == null)
                return;
            // await DisplayAlert("File Location", file.Path, "OK");
            image.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });
           // DisplayAlert("Image tapped", ":( No camera available.", "OK");
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
