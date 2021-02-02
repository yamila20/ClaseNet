using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.DataBase.Config
{
    public class TipoPagoConfig
    {
        public TipoPagoConfig(EntityTypeBuilder<TipoPago> entityBuilder)

        {

            entityBuilder.HasKey(x => x.id);

            entityBuilder.Property(x => x.tipoPago).HasMaxLength(50).IsRequired();

        }
    }
}
