using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotnetSimpleApi.Models
{
    public class WMuserViewModel
    {
        
        public WMuserViewModel()
        {
            this.wmprojectaccesses = new HashSet<WMprojectaccesViewModel>();
            this.wmtokens = new HashSet<WMtokenViewModel>();
        }

        public int id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string pwd { get; set; }
        public string route_img { get; set; }
        public string reset_password_token { get; set; }
        public Nullable<System.DateTime> reset_password_expires { get; set; }
        public Nullable<bool> status { get; set; }
        public Nullable<int> role_id { get; set; }
        public string name { get; set; }

        
        public virtual ICollection<WMprojectaccesViewModel> wmprojectaccesses { get; set; }
        public virtual WMroleViewModel wmrole { get; set; }
        
        public virtual ICollection<WMtokenViewModel> wmtokens { get; set; }
    }
}