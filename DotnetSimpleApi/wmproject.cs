//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotnetSimpleApi
{
    using System;
    using System.Collections.Generic;
    
    public partial class wmproject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public wmproject()
        {
            this.wmprojectaccesses = new HashSet<wmprojectaccess>();
            this.wmsprints = new HashSet<wmsprint>();
        }
    
        public string id { get; set; }
        public string name { get; set; }
        public string descr { get; set; }
        public string acr { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wmprojectaccess> wmprojectaccesses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wmsprint> wmsprints { get; set; }
    }
}
