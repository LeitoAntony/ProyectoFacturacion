﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PedidosFacturacion
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CargaPedidoDBEntities : DbContext
    {
        public CargaPedidoDBEntities()
            : base("name=CargaPedidoDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Local> Local { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<Asignador> Asignador { get; set; }
        public DbSet<Facturista> Facturista { get; set; }
        public DbSet<Operario> Operario { get; set; }
        public DbSet<Segmentos> Segmentos { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<Estados> Estados { get; set; }
    }
}
