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
    
    public partial class Twix_Wyniki
    {
        public System.DateTime DATA { get; set; }
        public int ID { get; set; }
        public Nullable<int> WYNIK { get; set; }
        public Nullable<int> ID_KLIENTA { get; set; }
    
        public virtual Twix_Klienci Twix_Klienci { get; set; }
    }
}