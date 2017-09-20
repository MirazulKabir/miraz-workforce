using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkForceApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkForceApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfileContainer : ContentView
	{

        string profile_name;
        string profile_designation;
        string profile_route;
        
        public string Profile_name
        {
            set  {   profile_name = value;  name.Text = value; }
            get { return profile_name; }
        }

        public string Profile_Designation {
            set { profile_designation = value; ; designantion.Text = value; }
            get { return profile_designation; }
        }

        public string Profile_Route
        {
            set { profile_route = value; ; route.Text = value; }
            get { return profile_route; }
        }

        public ProfileContainer ()
		{
			InitializeComponent ();
            //BindingContext = new User { name = "Ovie", designation = "No Designation", route_names = "Dhanmondi 3A" };
            BindingContext = new User { name = JsonHandler._jsonInstance._userInfo[0].name,
            designation = JsonHandler._jsonInstance._userInfo[0].designation,
            route_names = JsonHandler._jsonInstance._userInfo[0].route};
        }
	}
}