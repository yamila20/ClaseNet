using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.DataBase
{
    class Pedido
    {
        int NroPedido { get; set; }
        string nombreCliente { get; set; }
        int nroTelefono { get; set; }
        int idEstado { get; set; }
        int idPizza { get; set; }
    }
}
