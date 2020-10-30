using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScoutAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ScoutAPI.Repository
{
    public class ScoutSectionMap : IEntityTypeConfiguration<ScoutSection>
    {
        public void Configure(EntityTypeBuilder<ScoutSection> builder)
        {
            builder.ToTable("Scout_Section", "dbo");
            builder.HasKey(x => x.SectionCode);

            builder.Property(x => x.SectionCode).HasColumnName("section_code").HasColumnType("char(2)").HasMaxLength(2);
            builder.Property(x => x.SectionDescription).HasColumnName("section_description").HasColumnType("varchar(255)").HasMaxLength(255);

            builder.HasMany(x => x.Forms).WithOne(y => y.ScoutSection).HasForeignKey(z => z.SectionCode);
        }
    }
}
