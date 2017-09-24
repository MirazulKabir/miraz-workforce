using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace WorkForceApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            //Miraz

            // MainPage = new WorkForceApp.ActivityList();
            // MainPage = new NavigationPage(new MainPage());
            MainPage = new NavigationPage(new ActivityList());
           
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
