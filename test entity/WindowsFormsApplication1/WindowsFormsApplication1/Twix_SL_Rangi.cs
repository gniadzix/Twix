//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Twix_SL_Rangi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Twix_SL_Rangi()
        {
            this.Twix_Klienci = new HashSet<Twix_Klienci>();
        }
    
        public int ID { get; set; }
        public string NAZWA { get; set; }
        public byte[] SYMBOL { get; set; }
        public Nullable<int> ZNIZKA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Twix_Klienci> Twix_Klienci { get; set; }
    }
}
