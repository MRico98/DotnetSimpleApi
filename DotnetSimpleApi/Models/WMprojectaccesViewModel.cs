using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotnetSimpleApi.Models
{
    public class WMprojectaccesViewModel
    {
        public int id { get; set; }
        public string project_id { get; set; }
        public Nullable<int> users_id { get; set; }

        public virtual WMprojectViewModel wmproject { get; set; }
        public virtual WMuserViewModel wmuser { get; set; }
    }
}