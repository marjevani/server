﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class movieDBConnection : DbContext
    {
        public movieDBConnection()
            : base("name=movieDBConnection")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CustomerBuyTicket> CustomerBuyTickets { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<PlayTime> PlayTimes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
