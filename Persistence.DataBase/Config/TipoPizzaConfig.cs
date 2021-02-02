using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.DataBase.Config
{
    public class TipoPizzaConfig
    {
        public TipoPizzaConfig(EntityTypeBuilder<TipoPizza> entityBuilder)

        {

            entityBuilder.HasKey(x => x.id);

            entityBuilder.Property(x => x.nombre).HasMaxLength(50).IsRequired();
            entityBuilder.Property(x => x.descripcion).HasMaxLength(50).IsRequired();

        }
    }
}
