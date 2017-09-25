using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using WorkForceApp.Database;
using WorkForceApp.Model;

namespace WorkForceApp
{

    public class RootObject
    {
        public List<User> user { get; set; }
        public List<AppointmentClass> appointment { get; set; }
    }

    class JsonHandler
    {
        public static JsonHandler _jsonInstance = new JsonHandler();

        private const string Url = "http://shuruappsolution.com/appointments.json";
        private HttpClient _client = new HttpClient();

        public ObservableCollection<AppointmentClass> _appoinment;
        public ObservableCollection<User> _userInfo;

        public static JsonHandler Instance()
        {
            //get
            //{
            //if (_jsonInstance == null)
            //{
            //_jsonInstance = new JsonHandler();
            //}
            return _jsonInstance;
            //}
        }

        public JsonHandler()
        {

        }

        public async void MyJsonParser()
        {
            var jsonContent = await _client.GetStringAsync(Url);
            var rootObject = JsonConvert.DeserializeObject<RootObject>(jsonContent);

            _userInfo = new ObservableCollection<User>(rootObject.user);
            _appoinment = new ObservableCollection<AppointmentClass>(rootObject.appointment);

            DbHandler.Instance().ConnectDb();

            IEnumerable<User> user_IE = _userInfo as IEnumerable<User>;
            IEnumerable<AppointmentClass> appoinment_IE = _appoinment as IEnumerable<AppointmentClass>;

            DbHandler.Instance().InsertData<User>(user_IE);
            DbHandler.Instance().InsertData<AppointmentClass>(appoinment_IE);

        }

    }
}
