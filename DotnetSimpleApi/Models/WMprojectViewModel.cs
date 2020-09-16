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
            this.wmprojectaccesses = new HashSet<WMprojectaccesViewModel>();
            this.wmsprints = new HashSet<WMsprintViewModel>();
        }

        public string id { get; set; }
        public string name { get; set; }
        public string descr { get; set; }
        public string acr { get; set; }
        public virtual ICollection<WMprojectaccesViewModel> wmprojectaccesses { get; set; }
        public virtual ICollection<WMsprintViewModel> wmsprints { get; set; }
    }
}