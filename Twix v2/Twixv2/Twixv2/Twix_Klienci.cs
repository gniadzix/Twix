//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Twixv2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Twix_Klienci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Twix_Klienci()
        {
            this.Twix_Rezerwacja = new HashSet<Twix_Rezerwacja>();
        }
    
        public int ID { get; set; }
        public string IMIE { get; set; }
        public string NAZWISKO { get; set; }
        public string PESEL { get; set; }
        public string NR_DOWODU { get; set; }
        public Nullable<int> ID_RANGI { get; set; }
        public string LOGIN { get; set; }
        public string HASLO { get; set; }
        public byte[] czyADMIN { get; set; }
    
        public virtual Twix_SL_Rangi Twix_SL_Rangi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Twix_Rezerwacja> Twix_Rezerwacja { get; set; }
    }
}
