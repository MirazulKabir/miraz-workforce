
using WorkForceApp.Activity_Pages;
using Xamarin.Forms;

namespace WorkForceApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            // MainPage = new WorkForceApp.ActivityList();
            // MainPage = new NavigationPage(new MainPage());
            MainPage = new NavigationPage(new AssignmentList());

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
