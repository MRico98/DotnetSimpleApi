using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotnetSimpleApi.Models
{
    public class WMtokenViewModel
    {
        public int id { get; set; }
        public string token { get; set; }
        public Nullable<System.DateTime> expiration_date { get; set; }
        public Nullable<int> id_user { get; set; }

        public virtual WMuserViewModel wmuser { get; set; }
    }
}