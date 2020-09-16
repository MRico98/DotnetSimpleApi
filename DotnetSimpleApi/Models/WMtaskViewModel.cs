using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotnetSimpleApi.Models
{
    public class WMtaskViewModel
    {
        public int id { get; set; }
        public Nullable<int> id_sprint { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public Nullable<double> time_estimate { get; set; }
        public Nullable<double> time_worked { get; set; }
        public Nullable<double> time_remaining { get; set; }
        public string status { get; set; }
        public Nullable<bool> is_req { get; set; }

        public virtual WMsprintViewModel wmsprint { get; set; }
    }
}