using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.DataBase.Config
{
    public class ClienteConfig
    {
        public ClienteConfig(EntityTypeBuilder<Cliente> entityBuilder)

        {

            entityBuilder.HasKey(x => x.id);

            entityBuilder.Property(x => x.nombre).HasMaxLength(50).IsRequired();
            entityBuilder.Property(x => x.apellido).HasMaxLength(50).IsRequired();
            entityBuilder.Property(x => x.domicilio).HasMaxLength(100).IsRequired();
            entityBuilder.Property(x => x.telefono).HasMaxLength(50).IsRequired();

        }
    }
}
