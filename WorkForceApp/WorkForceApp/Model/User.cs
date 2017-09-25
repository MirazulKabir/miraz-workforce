using SQLite;

namespace WorkForceApp.Model
{
    public class User
    {
        [PrimaryKey]
        public string id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string designation { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string route { get; set; }

    }
}
