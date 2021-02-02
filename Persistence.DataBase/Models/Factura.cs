using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.DataBase.Models
{
    public class Factura
    {
        public int id { get; set; }
        public int numero { get; set; }
        public DateTime fechaEmision { get; set; }
        public DateTime horaEmision { get; set; }
        public int idPedido { get; set; }
        public Pedido Pedido { get; set; }
        public int idEstadoFactura { get; set; }
        public EstadoFactura EstadoFactura { get; set; }
        public int idTipoPago { get; set; }
        public TipoPago TipoPago{get;set;}

    }
}
