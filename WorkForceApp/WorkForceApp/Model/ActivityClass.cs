using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkForceApp.Model
{
    class ActivityClass
    {
        public long activity_id { get; set; }
        public string title { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
        public string date { get; set; }
        public int user_id { get; set; }
        public string sr_note { get; set; }
    }
}
