﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Twix : DbContext
    {
        public Twix()
            : base("name=Twix")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Twix_Bron_Amunicja> Twix_Bron_Amunicja { get; set; }
        public virtual DbSet<Twix_Klienci> Twix_Klienci { get; set; }
        public virtual DbSet<Twix_Rezerwacja> Twix_Rezerwacja { get; set; }
        public virtual DbSet<Twix_SL_Amunicji> Twix_SL_Amunicji { get; set; }
        public virtual DbSet<Twix_SL_Broni> Twix_SL_Broni { get; set; }
        public virtual DbSet<Twix_SL_Rangi> Twix_SL_Rangi { get; set; }
        public virtual DbSet<Twix_SL_Torow> Twix_SL_Torow { get; set; }
        public virtual DbSet<Twix_Wyniki> Twix_Wyniki { get; set; }
    }
}
