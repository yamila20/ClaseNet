using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.DataBase.Models
{
    class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog = Pizzeria; Integrated Security = True");
        }
        public virtual DbSet<Cliente> Cliente{get;set;}
        public virtual DbSet<DetallePedido> DetallePedido { get; set; }
        public virtual DbSet<EstadoFactura> EstadoFactura { get; set; }
        public virtual DbSet<EstadoPedido> EstadoPedido { get; set; }
        public virtual DbSet<Factura> Factura  { get; set; }
        public virtual DbSet<Ingredientes> Ingredientes  { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<Pizza> Pizza{ get; set; }
        public virtual DbSet<TamañoPizza> TamañoPizza { get; set; }
        public virtual DbSet<TipoPizza> TipoPizza { get; set; }
        public virtual DbSet<TipoPago> TipoPago  { get; set; }
        public virtual DbSet<VariedadPizza> VariedadPizza { get; set; }
        public virtual DbSet<Vendedor> Vendedor { get; set; }
    }
}
