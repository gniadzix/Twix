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
    
    public partial class Twix_SL_Amunicji
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Twix_SL_Amunicji()
        {
            this.Twix_Bron_Amunicja = new HashSet<Twix_Bron_Amunicja>();
        }
    
        public int ID { get; set; }
        public string KALIBER { get; set; }
        public Nullable<decimal> CENA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Twix_Bron_Amunicja> Twix_Bron_Amunicja { get; set; }
    }
}
