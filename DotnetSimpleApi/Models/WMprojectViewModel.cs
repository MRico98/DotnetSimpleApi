using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotnetSimpleApi.Models
{
    public class WMprojectViewModel
    {
        public WMprojectViewModel()
        {
            this.wmprojectaccesses = new HashSet<wmprojectaccess>();
            this.wmsprints = new HashSet<wmsprint>();
        }

        public string id { get; set; }
        public string name { get; set; }
        public string descr { get; set; }
        public string acr { get; set; }
        public virtual ICollection<wmprojectaccess> wmprojectaccesses { get; set; }
        public virtual ICollection<wmsprint> wmsprints { get; set; }
    }
}