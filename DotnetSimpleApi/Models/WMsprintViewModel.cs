using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotnetSimpleApi.Models
{
    public class WMsprintViewModel
    {
        public WMsprintViewModel()
        {
            this.wmtasks = new HashSet<WMtaskViewModel>();
        }

        public int id { get; set; }
        public string id_project { get; set; }
        public Nullable<System.DateTime> date_init { get; set; }
        public Nullable<System.DateTime> date_end { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<bool> is_completed { get; set; }
        public string namesprint { get; set; }

        public virtual WMprojectViewModel wmproject { get; set; }
        public virtual ICollection<WMtaskViewModel> wmtasks { get; set; }
    }
}