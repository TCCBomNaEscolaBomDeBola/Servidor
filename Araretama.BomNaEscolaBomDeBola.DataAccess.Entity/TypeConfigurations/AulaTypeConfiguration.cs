﻿using Araretama.BomNaEscolaBomDeBola.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araretama.BomNaEscolaBomDeBola.DataAccess.Entity.TypeConfigurations
{
    class AulaTypeConfiguration : EntityTypeConfiguration<Aula>
    {
        public AulaTypeConfiguration()
        {
            ToTable("TB_AULA");
            Property(p => p.Id)
                    .HasColumnName("AUL_ID")
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                    .IsRequired();

            Property(p => p.IDTurma)
                  .HasColumnName("TUR_ID");
            Property(p => p.Horario)
                 .HasColumnName("AUL_HORARIO");
            Property(p => p.DataEnvio)
                 .HasColumnName("AUL_DATAENVIO");
            Property(p => p.DataAula)
                 .HasColumnName("AUL_DATAAULA");

        }
    }
}
