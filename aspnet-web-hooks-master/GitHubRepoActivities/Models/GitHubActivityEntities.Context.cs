﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace GitHubRepoActivities.Models
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class RaviDevDBEntities : DbContext
{
    public RaviDevDBEntities()
        : base("name=RaviDevDBEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<GitHubActivity> GitHubActivities { get; set; }

}

}
