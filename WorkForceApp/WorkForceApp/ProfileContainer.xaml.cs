using System.Collections.ObjectModel;
using WorkForceApp.Database;
using WorkForceApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkForceApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfileContainer : ContentView
    {
        //   ObservableCollection<User> userCollection;
        private ObservableCollection<User> userCollection;

        string profile_name;
        string profile_designation;
        string profile_route;

        public string Profile_name
        {
            set { profile_name = value; name.Text = value; }
            get { return profile_name; }
        }

        public string Profile_Designation
        {
            set { profile_designation = value; ; designantion.Text = value; }
            get { return profile_designation; }
        }

        public string Profile_Route
        {
            set { profile_route = value; ; route.Text = value; }
            get { return profile_route; }
        }

        public ProfileContainer()
        {
            InitializeComponent();

            habla();

        }

        async void habla()
        {
            // SQLiteAsyncConnection _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            var users = await DbHandler._dbHandlerInstance.GetConnection().Table<User>().ToListAsync();
            userCollection = new ObservableCollection<User>(users);
            User u = userCollection[0];

            BindingContext = u;
        }
    }
}