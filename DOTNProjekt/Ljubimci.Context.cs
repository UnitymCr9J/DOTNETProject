﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DOTNProjekt
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ZivotinjeEntities : DbContext
    {
        public ZivotinjeEntities()
            : base("name=ZivotinjeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<drzave> drzave { get; set; }
        public virtual DbSet<macke> macke { get; set; }
        public virtual DbSet<psi> psi { get; set; }
    }
}