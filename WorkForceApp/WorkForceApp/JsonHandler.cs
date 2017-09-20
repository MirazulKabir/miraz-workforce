using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WorkForceApp
{
    public class Userinfo
    {
        public string name { get; set; }
        public string designation { get; set; }
        public string id { get; set; }
        public string route { get; set; }
        public string image { get; set; }
    }

    public class Appoinment
    {
        public string name { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }

    public class RootObject
    {
        public List<Userinfo> userinfo { get; set; }
        public List<Appoinment> appoinments { get; set; }
    }

    class JsonHandler
    {
        public static JsonHandler _jsonInstance = new JsonHandler();

        private const string Url = "http://shuruappsolution.com/appointments.json";
        private HttpClient _client = new HttpClient();
        public ObservableCollection<Appoinment> _appoinment;
        public ObservableCollection<Userinfo> _userInfo;

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

            _userInfo = new ObservableCollection<Userinfo>(rootObject.userinfo);
            _appoinment = new ObservableCollection<Appoinment>(rootObject.appoinments);
        }

    }
}
