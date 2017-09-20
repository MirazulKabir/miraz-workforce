
using System;
using WorkForceApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkForceApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OutletDetails : ContentView
    {

        public delegate void OutletButtonClickedEventHandler(object source, EventArgs args);
        public static event OutletButtonClickedEventHandler StartButtonClicked;


        string address;
        string name;

        public static readonly BindableProperty Outlet_nameProperty =
        BindableProperty.Create("Outlet_name", typeof(string), typeof(OutletDetails), null);

        public string Outlet_name
        {
            set { name = value; outlet_name.Text = value; }
            get { return name; }
        }

        public string OutletAddress
        {
            set { address = value; outlet_address.Text = value; }
            get { return address; }
        }

        public OutletDetails()
        {
            InitializeComponent();

            start_time_btn.Clicked += (object sender, EventArgs e) => {
                OnStartButtonClicked();
            };
        }



        protected virtual void OnStartButtonClicked()
        {

            if (StartButtonClicked != null)
            {
                // Log.Error("TAG", "In OutletDetails " + StartButtonClicked);

                StartButtonClicked(this, EventArgs.Empty);
            }
        }


    }
}