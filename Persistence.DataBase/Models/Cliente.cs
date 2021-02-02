using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.DataBase.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string domicilio { get; set; }
        public int telefono { get; set; }
    }
}
