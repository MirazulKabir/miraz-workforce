using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkForceApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OutletDetails : ContentView
	{
        string address;
        string name;
        public string Outlet_name
        {
            set { name = value; outlet_name.Text = value; }
            get { return name; }
        }

        public string OutletAddress
         {
             set { address = value; ; outlet_address.Text = value; }
             get { return address; }
         }

        public OutletDetails ()
		{
			InitializeComponent ();
		}

        private void start_time_btn_Clicked(object sender, EventArgs e)
        {
            outlet_name.Text = "Button Clicked";
        }
    }
}