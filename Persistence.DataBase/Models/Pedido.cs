using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.DataBase.Models
{
    public class Pedido
    {
        public int id { get; set; }
        public DateTime hora { get; set; }
        public int idCliente { get; set; }
        public Cliente Cliente { get; set; }
        public int idVendedor { get; set; }
        public Vendedor Vendedor { get; set; }
        public int idEstadoPedido { get; set; }
        public EstadoPedido EstadoPedido { get; set; }
        public int idDetallePedido { get; set; }
        public DetallePedido DetallePedido { get; set; }
    }
}
