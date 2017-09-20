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
	public partial class ActivityList : ContentPage
	{

        public enum Modes
        {
           ListMode,DetailsMode
        }
        Modes modes;

        public ActivityList ()
		{
          
            InitializeComponent ();

            ProfileContainer profile = new ProfileContainer();


            modes = Modes.ListMode;
          
            List<Tasks> taskLists = new List<Tasks>();

            for (int i = 0; i < 5; i++)
            {
                Tasks task = new Tasks { name = "Task "+i, startTime = "10", endTime = "11" };
                taskLists.Add(task);
            }
          // listView.ItemsSource = taskLists;
          
		}
  
    }
}