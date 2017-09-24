namespace WorkForceApp.Model
{
    public class AppointmentClass
    {
        public string id { get; set; }
        public string name { get; set; }
        public int type_id { get; set; }
        public string date { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
        public string manager_note { get; set; }
        public string sr_note { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string address { get; set; }
        public string contact_name { get; set; }
        public string contact_phone { get; set; }
    }
}
