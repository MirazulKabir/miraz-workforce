
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


            var appoinments = await DbHandler._dbHandlerInstance.GetConnection().Table<AppointmentClass>().ToListAsync();

            appoinment_list.ItemsSource = appoinments;

        }

        private void appoinment_list_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            //DisplayAlert("Selected ", appoinment.name, "Ok");
            appoinment_list.SelectedItem = null;
        }

        private void map_btn_Clicked(object sender, System.EventArgs e)
        {
            var item = (Xamarin.Forms.Button)sender;
            var appoinment = item.CommandParameter as AppointmentClass;
            DisplayAlert("Map ", appoinment.name, "Ok");
        }

        private void appoinment_list_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var appoinment = e.Item as AppointmentClass;
            Navigation.PushAsync(new AppoinmentDetailsPage(appoinment));
        }
    }
}