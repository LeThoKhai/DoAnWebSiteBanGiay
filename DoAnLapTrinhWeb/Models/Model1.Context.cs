﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnLapTrinhWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WebBanGiayDataEntities1 : DbContext
    {
        public WebBanGiayDataEntities1()
            : base("name=WebBanGiayDataEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CHITIETDONDATHANG> CHITIETDONDATHANG { get; set; }
        public virtual DbSet<DONDATHANG> DONDATHANG { get; set; }
        public virtual DbSet<GIAY> GIAY { get; set; }
        public virtual DbSet<LOAIGIAY> LOAIGIAY { get; set; }
        public virtual DbSet<NHASANXUAT> NHASANXUAT { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOAN { get; set; }
    }
}