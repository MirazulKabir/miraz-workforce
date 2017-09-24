using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkForceApp.Model
{
   public class Tasks
    {
       [PrimaryKey,AutoIncrement]
       public int id { get; set; }

       public string name { get; set; }
       public string outletName { get; set; }
       public string startTime { get; set; }
       public string endTime { get; set; }
    }
}
