﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Triad.CabinetOffice.Slipping.Data.EntityFramework.PAWS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PAWSEntities : DbContext
    {
        public PAWSEntities()
            : base("name=PAWSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Absence_Request> Absence_Requests { get; set; }
        public virtual DbSet<Members_of_Parliament> Members_of_Parliaments { get; set; }
        public virtual DbSet<Absence_Request_Status> Absence_Request_Status { get; set; }
        public virtual DbSet<Absence_Request_Reason> Absence_Request_Reasons { get; set; }
    }
}
