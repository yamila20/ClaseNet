using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.DataBase.Models
{
    public class DetallePedido
    {
        public int id { get; set; }
        public int cantidad { get; set; }
        public double subTotal { get; set; }
        public int idPizza { get; set; }
        public Pizza Pizza { get; set; }
        public int idFactura { get; set; }
        public Factura Factura { get; set; }
    }
}
