﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
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
        public DbSet<Estados> Estados { get; set; }
    }
}
