﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.DataBase.Models;

namespace Persistence.DataBase.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Persistence.DataBase.Models.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("domicilio")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("telefono")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Persistence.DataBase.Models.DetallePedido", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Facturaid")
                        .HasColumnType("int");

                    b.Property<int?>("Pizzaid")
                        .HasColumnType("int");

                    b.Property<int>("cantidad")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("idFactura")
                        .HasColumnType("int");

                    b.Property<int>("idPizza")
                        .HasColumnType("int");

                    b.Property<double>("subTotal")
                        .HasMaxLength(50)
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("Facturaid");

                    b.HasIndex("Pizzaid");

                    b.ToTable("DetallePedido");
                });

            modelBuilder.Entity("Persistence.DataBase.Models.EstadoFactura", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("EstadoFactura");
                });

            modelBuilder.Entity("Persistence.DataBase.Models.EstadoPedido", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("EstadoPedido");
                });

            modelBuilder.Entity("Persistence.DataBase.Models.Factura", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("EstadoFacturaid")
                        .HasColumnType("int");

                    b.Property<int?>("Pedidoid")
                        .HasColumnType("int");

                    b.Property<int?>("TipoPagoid")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaEmision")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("horaEmision")
                        .HasColumnType("datetime2");

                    b.Property<int>("idEstadoFactura")
                        .HasColumnType("int");

                    b.Property<int>("idPedido")
                        .HasColumnType("int");

                    b.Property<int>("idTipoPago")
                        .HasColumnType("int");

                    b.Property<int>("numero")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("EstadoFacturaid");

                    b.HasIndex("Pedidoid");

                    b.HasIndex("TipoPagoid");

                    b.ToTable("Factura");
                });

            modelBuilder.Entity("Persistence.DataBase.Models.Ingredientes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ingrediente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("Ingredientes");
                });

            modelBuilder.Entity("Persistence.DataBase.Models.Pedido", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Clienteid")
                        .HasColumnType("int");

                    b.Property<int?>("DetallePedidoid")
                        .HasColumnType("int");

                    b.Property<int?>("EstadoPedidoid")
                        .HasColumnType("int");

                    b.Property<int?>("Vendedorid")
                        .HasColumnType("int");

                    b.Property<DateTime>("hora")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<int>("idCliente")
                        .HasColumnType("int");

                    b.Property<int>("idDetallePedido")
                        .HasColumnType("int");

                    b.Property<int>("idEstadoPedido")
                        .HasColumnType("int");

                    b.Property<int>("idVendedor")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Clienteid");

                    b.HasIndex("DetallePedidoid");

                    b.HasIndex("EstadoPedidoid");

                    b.HasIndex("Vendedorid");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("Persistence.DataBase.Models.Pizza", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("TamañoPizzaid")
                        .HasColumnType("int");

                    b.Property<int?>("TipoPizzaid")
                        .HasColumnType("int");

                    b.Property<int?>("VariedadPizzaid")
                        .HasColumnType("int");

                    b.Property<int>("idTamañoPizza")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<int>("idTipoPizza")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("idVariedadPizza")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("precio")
                        .HasMaxLength(50)
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("TamañoPizzaid");

                    b.HasIndex("TipoPizzaid");

                    b.HasIndex("VariedadPizzaid");

                    b.ToTable("Pizza");
                });

            modelBuilder.Entity("Persistence.DataBase.Models.TamañoPizza", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("cantidadPorciones")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("TamañoPizza");
                });

            modelBuilder.Entity("Persistence.DataBase.Models.TipoPago", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("tipoPago")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("TipoPago");
                });

            modelBuilder.Entity("Persistence.DataBase.Models.TipoPizza", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("TipoPizza");
                });

            modelBuilder.Entity("Persistence.DataBase.Models.VariedadPizza", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("idIngrediente")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("VariedadPizza");
                });

            modelBuilder.Entity("Persistence.DataBase.Models.Vendedor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("apellido")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("domicilio")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("telefono")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("Persistence.DataBase.Models.DetallePedido", b =>
                {
                    b.HasOne("Persistence.DataBase.Models.Factura", "Factura")
                        .WithMany()
                        .HasForeignKey("Facturaid");

                    b.HasOne("Persistence.DataBase.Models.Pizza", "Pizza")
                        .WithMany()
                        .HasForeignKey("Pizzaid");

                    b.Navigation("Factura");

                    b.Navigation("Pizza");
                });

            modelBuilder.Entity("Persistence.DataBase.Models.Factura", b =>
                {
                    b.HasOne("Persistence.DataBase.Models.EstadoFactura", "EstadoFactura")
                        .WithMany()
                        .HasForeignKey("EstadoFacturaid");

                    b.HasOne("Persistence.DataBase.Models.Pedido", "Pedido")
                        .WithMany()
                        .HasForeignKey("Pedidoid");

                    b.HasOne("Persistence.DataBase.Models.TipoPago", "TipoPago")
                        .WithMany()
                        .HasForeignKey("TipoPagoid");

                    b.Navigation("EstadoFactura");

                    b.Navigation("Pedido");

                    b.Navigation("TipoPago");
                });

            modelBuilder.Entity("Persistence.DataBase.Models.Pedido", b =>
                {
                    b.HasOne("Persistence.DataBase.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("Clienteid");

                    b.HasOne("Persistence.DataBase.Models.DetallePedido", "DetallePedido")
                        .WithMany()
                        .HasForeignKey("DetallePedidoid");

                    b.HasOne("Persistence.DataBase.Models.EstadoPedido", "EstadoPedido")
                        .WithMany()
                        .HasForeignKey("EstadoPedidoid");

                    b.HasOne("Persistence.DataBase.Models.Vendedor", "Vendedor")
                        .WithMany()
                        .HasForeignKey("Vendedorid");

                    b.Navigation("Cliente");

                    b.Navigation("DetallePedido");

                    b.Navigation("EstadoPedido");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("Persistence.DataBase.Models.Pizza", b =>
                {
                    b.HasOne("Persistence.DataBase.Models.TamañoPizza", "TamañoPizza")
                        .WithMany()
                        .HasForeignKey("TamañoPizzaid");

                    b.HasOne("Persistence.DataBase.Models.TipoPizza", "TipoPizza")
                        .WithMany()
                        .HasForeignKey("TipoPizzaid");

                    b.HasOne("Persistence.DataBase.Models.VariedadPizza", "VariedadPizza")
                        .WithMany()
                        .HasForeignKey("VariedadPizzaid");

                    b.Navigation("TamañoPizza");

                    b.Navigation("TipoPizza");

                    b.Navigation("VariedadPizza");
                });
#pragma warning restore 612, 618
        }
    }
}