﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CUENTAS_POR_PAGAR
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SCXPRAUDOEntities : DbContext
    {
        public SCXPRAUDOEntities()
            : base("name=SCXPRAUDOEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CHEQUE> CHEQUES { get; set; }
        public virtual DbSet<FACTURA> FACTURAS { get; set; }
        public virtual DbSet<PROVEEDORE> PROVEEDORES { get; set; }
        public virtual DbSet<USUARIO> USUARIOS { get; set; }
        public virtual DbSet<estado_de_cuentas> estado_de_cuentas { get; set; }
    }
}
