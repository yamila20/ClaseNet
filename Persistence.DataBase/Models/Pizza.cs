using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.DataBase.Models
{
    public class Pizza
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public int idTipoPizza { get; set; }
        public TipoPizza TipoPizza { get; set; }
        public int idTamañoPizza { get; set; }
        public TamañoPizza TamañoPizza { get; set; }
        public int idVariedadPizza { get; set; }
        public VariedadPizza VariedadPizza { get; set; }
    }
}
