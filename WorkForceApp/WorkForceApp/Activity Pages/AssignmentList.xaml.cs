
using WorkForceApp.Database;
using WorkForceApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkForceApp.Activity_Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssignmentList : ContentPage
    {
        public AssignmentList()
        {
            InitializeComponent();

            GetAllData();
        }


        async void GetAllData()
        {

            // SQLiteAsyncConnection _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            var appoinments = await DbHandler._dbHandlerInstance.GetConnection().Table<AppointmentClass>().ToListAsync();

            appoinment_list.ItemsSource = appoinments;
            // userCollection = new ObservableCollection<User>(users);
            //  BindingContext = u;
        }
    }
}