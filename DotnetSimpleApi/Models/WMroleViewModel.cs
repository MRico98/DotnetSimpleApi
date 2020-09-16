using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotnetSimpleApi.Models
{
    public class WMroleViewModel
    {
        public WMroleViewModel()
        {
            this.wmusers = new HashSet<WMuserViewModel>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public virtual ICollection<WMuserViewModel> wmusers { get; set; }
    }
}