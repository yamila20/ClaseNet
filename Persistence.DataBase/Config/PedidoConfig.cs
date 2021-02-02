using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.DataBase.Config
{
    public class PedidoConfig
    {
        public PedidoConfig(EntityTypeBuilder<Pedido> entityBuilder)

        {

            entityBuilder.HasKey(x => x.id);
            entityBuilder.Property(x => x.hora).HasMaxLength(50).IsRequired();

        }
    }
}
