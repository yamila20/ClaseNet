using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.DataBase.Config
{
    public class IngredienteConfig
    {
        public IngredienteConfig(EntityTypeBuilder<Ingredientes> entityBuilder)

        {

            entityBuilder.HasKey(x => x.id);

            entityBuilder.Property(x => x.ingrediente).HasMaxLength(50).IsRequired();

        }
    }
}
