﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kino.Properties
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KinoEntities : DbContext
    {
        public KinoEntities()
            : base("name=KinoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dim> Dims { get; set; }
        public virtual DbSet<DimsMovie> DimsMovies { get; set; }
        public virtual DbSet<Hall> Halls { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<MovieState> MovieStates { get; set; }
        public virtual DbSet<MovieType> MovieTypes { get; set; }
        public virtual DbSet<Pack> Packs { get; set; }
        public virtual DbSet<PackPO> PackPOes { get; set; }
        public virtual DbSet<Performance> Performances { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonType> PersonTypes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<SalePO> SalePOes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Timetable> Timetables { get; set; }
        public virtual DbSet<MoviePerson> MoviePersons { get; set; }
    }
}