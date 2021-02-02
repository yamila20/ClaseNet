using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.DataBase.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    domicilio = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    telefono = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoFactura",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoFactura", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoPedido",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoPedido", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ingrediente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredientes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TamañoPizza",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cantidadPorciones = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TamañoPizza", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPago",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoPago = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPago", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPizza",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPizza", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "VariedadPizza",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    idIngrediente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VariedadPizza", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Vendedor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    domicilio = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    telefono = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedor", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pizza",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    precio = table.Column<double>(type: "float", maxLength: 50, nullable: false),
                    idTipoPizza = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    TipoPizzaid = table.Column<int>(type: "int", nullable: true),
                    idTamañoPizza = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    TamañoPizzaid = table.Column<int>(type: "int", nullable: true),
                    idVariedadPizza = table.Column<int>(type: "int", nullable: false),
                    VariedadPizzaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizza", x => x.id);
                    table.ForeignKey(
                        name: "FK_Pizza_TamañoPizza_TamañoPizzaid",
                        column: x => x.TamañoPizzaid,
                        principalTable: "TamañoPizza",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pizza_TipoPizza_TipoPizzaid",
                        column: x => x.TipoPizzaid,
                        principalTable: "TipoPizza",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pizza_VariedadPizza_VariedadPizzaid",
                        column: x => x.VariedadPizzaid,
                        principalTable: "VariedadPizza",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hora = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    idCliente = table.Column<int>(type: "int", nullable: false),
                    Clienteid = table.Column<int>(type: "int", nullable: true),
                    idVendedor = table.Column<int>(type: "int", nullable: false),
                    Vendedorid = table.Column<int>(type: "int", nullable: true),
                    idEstadoPedido = table.Column<int>(type: "int", nullable: false),
                    EstadoPedidoid = table.Column<int>(type: "int", nullable: true),
                    idDetallePedido = table.Column<int>(type: "int", nullable: false),
                    DetallePedidoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.id);
                    table.ForeignKey(
                        name: "FK_Pedido_Cliente_Clienteid",
                        column: x => x.Clienteid,
                        principalTable: "Cliente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedido_EstadoPedido_EstadoPedidoid",
                        column: x => x.EstadoPedidoid,
                        principalTable: "EstadoPedido",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedido_Vendedor_Vendedorid",
                        column: x => x.Vendedorid,
                        principalTable: "Vendedor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numero = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    fechaEmision = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    horaEmision = table.Column<DateTime>(type: "datetime2", nullable: false),
                    idPedido = table.Column<int>(type: "int", nullable: false),
                    Pedidoid = table.Column<int>(type: "int", nullable: true),
                    idEstadoFactura = table.Column<int>(type: "int", nullable: false),
                    EstadoFacturaid = table.Column<int>(type: "int", nullable: true),
                    idTipoPago = table.Column<int>(type: "int", nullable: false),
                    TipoPagoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.id);
                    table.ForeignKey(
                        name: "FK_Factura_EstadoFactura_EstadoFacturaid",
                        column: x => x.EstadoFacturaid,
                        principalTable: "EstadoFactura",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Factura_Pedido_Pedidoid",
                        column: x => x.Pedidoid,
                        principalTable: "Pedido",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Factura_TipoPago_TipoPagoid",
                        column: x => x.TipoPagoid,
                        principalTable: "TipoPago",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetallePedido",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cantidad = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    subTotal = table.Column<double>(type: "float", maxLength: 50, nullable: false),
                    idPizza = table.Column<int>(type: "int", nullable: false),
                    Pizzaid = table.Column<int>(type: "int", nullable: true),
                    idFactura = table.Column<int>(type: "int", nullable: false),
                    Facturaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallePedido", x => x.id);
                    table.ForeignKey(
                        name: "FK_DetallePedido_Factura_Facturaid",
                        column: x => x.Facturaid,
                        principalTable: "Factura",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallePedido_Pizza_Pizzaid",
                        column: x => x.Pizzaid,
                        principalTable: "Pizza",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedido_Facturaid",
                table: "DetallePedido",
                column: "Facturaid");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedido_Pizzaid",
                table: "DetallePedido",
                column: "Pizzaid");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_EstadoFacturaid",
                table: "Factura",
                column: "EstadoFacturaid");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_Pedidoid",
                table: "Factura",
                column: "Pedidoid");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_TipoPagoid",
                table: "Factura",
                column: "TipoPagoid");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_Clienteid",
                table: "Pedido",
                column: "Clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_DetallePedidoid",
                table: "Pedido",
                column: "DetallePedidoid");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_EstadoPedidoid",
                table: "Pedido",
                column: "EstadoPedidoid");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_Vendedorid",
                table: "Pedido",
                column: "Vendedorid");

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_TamañoPizzaid",
                table: "Pizza",
                column: "TamañoPizzaid");

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_TipoPizzaid",
                table: "Pizza",
                column: "TipoPizzaid");

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_VariedadPizzaid",
                table: "Pizza",
                column: "VariedadPizzaid");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_DetallePedido_DetallePedidoid",
                table: "Pedido",
                column: "DetallePedidoid",
                principalTable: "DetallePedido",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallePedido_Factura_Facturaid",
                table: "DetallePedido");

            migrationBuilder.DropTable(
                name: "Ingredientes");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "EstadoFactura");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "TipoPago");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "DetallePedido");

            migrationBuilder.DropTable(
                name: "EstadoPedido");

            migrationBuilder.DropTable(
                name: "Vendedor");

            migrationBuilder.DropTable(
                name: "Pizza");

            migrationBuilder.DropTable(
                name: "TamañoPizza");

            migrationBuilder.DropTable(
                name: "TipoPizza");

            migrationBuilder.DropTable(
                name: "VariedadPizza");
        }
    }
}
