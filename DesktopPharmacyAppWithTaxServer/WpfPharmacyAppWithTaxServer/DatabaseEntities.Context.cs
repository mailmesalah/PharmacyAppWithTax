﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfServerApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Database9004Entities : DbContext
    {
        public Database9004Entities()
            : base("name=Database9004Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<barcode_generator> barcode_generator { get; set; }
        public virtual DbSet<ledger_register> ledger_register { get; set; }
        public virtual DbSet<ledger_transactions> ledger_transactions { get; set; }
        public virtual DbSet<product_register> product_register { get; set; }
        public virtual DbSet<unit_register> unit_register { get; set; }
        public virtual DbSet<product_transactions> product_transactions { get; set; }
        public virtual DbSet<bill_nos> bill_nos { get; set; }
    }
}
