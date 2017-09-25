using System;
using WorkForceApp.Activity_Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkForceApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsersActivityList : ContentPage
    {
        public DateTimeNoda dateTimeNoda;

        public UsersActivityList()
        {
            InitializeComponent();
            dateTimeNoda = new DateTimeNoda();

            task_list.ItemsSource = JsonHandler._jsonInstance._appoinment;
        }

        private void start_time_btn_Clicked(object sender, EventArgs e)
        {
            String instantTime = dateTimeNoda.getInstantTime();
            String[] spltDateNTime = instantTime.Split('T');
            String date = spltDateNTime[0];
            String time = spltDateNTime[1];
            if (start_time_btn.Text.Equals("Start"))
            {
                start_time_btn.Text = "End";
                setLogedInfoToText(instantTime);
                Application.Current.Properties["startTime"] = time;
                Application.Current.Properties["rawDateAndtime"] = instantTime;
                Application.Current.Properties["date"] = date;
                Application.Current.SavePropertiesAsync();
            }
            else
            {
                String LoggedInTime = Application.Current.Properties["startTime"].ToString();
                String LoggedOutTime = time;
                String duration = dateTimeNoda.getTimeDifference(LoggedInTime, LoggedOutTime);
                String LoggedIn12 = dateTimeNoda.convert24To12(LoggedInTime);
                String LoggedOut12 = dateTimeNoda.convert24To12(LoggedOutTime);
                DisplayAlert("Duration", "Logged in: " + LoggedIn12 + " Logged Out: " + LoggedOut12 + " Duration: " + duration, "Ok");
            }
        }

        private async void assignments__btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AssignmentList());
        }

        private void setLogedInfoToText(String dateTime)
        {

            String[] spltDateNTime = dateTime.Split('T');
            String date = spltDateNTime[0];
            String time = spltDateNTime[1];
            String[] spltDate = date.Split('-');
            //date manipulation
            String day = dateTimeNoda.getDayName(date);
            String monthName = dateTimeNoda.getMonthName(date);
            String year = spltDate[0];
            lbl_login_info.Text = "Logged in " + day + ", " + monthName + " " + spltDate[1] + ", " + year;
            lbl_time_info.Text = "Started from " + dateTimeNoda.convert24To12(time);


        }
    }
}