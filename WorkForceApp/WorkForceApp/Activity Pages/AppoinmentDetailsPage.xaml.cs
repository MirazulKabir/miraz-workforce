using System;
using WorkForceApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkForceApp.Activity_Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppoinmentDetailsPage : ContentPage
    {
        public AppoinmentDetailsPage(AppointmentClass appoinment)
        {
            if (appoinment == null)
                throw new ArgumentNullException();

            BindingContext = appoinment;
            InitializeComponent();
        }
    }
}