﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEBAPIAUTH.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UCM85_dbEntities : DbContext
    {
        public UCM85_dbEntities()
            : base("name=UCM85_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CampaignDetails> CampaignDetails { get; set; }
        public virtual DbSet<SOCIALSHARINGDETAILS> SOCIALSHARINGDETAILS { get; set; }
        public virtual DbSet<USERACCESSTOKENASSOC> USERACCESSTOKENASSOC { get; set; }
    }
}
