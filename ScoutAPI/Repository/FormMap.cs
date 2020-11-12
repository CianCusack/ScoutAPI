using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScoutAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ScoutAPI.Repository
{
    public class FormMap : IEntityTypeConfiguration<FormApi>
    {
        public void Configure(EntityTypeBuilder<FormApi> builder)
        {
            builder.ToTable("Forms", "dbo");
            builder.HasKey(x => x.FormId);

            builder.Property(x => x.FormId).HasColumnName("id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.FirstName).HasColumnName("first_name").HasColumnType("varchar(30)").HasMaxLength(30);
            builder.Property(x => x.Surname).HasColumnName("surname").HasColumnType("varchar(30)").HasMaxLength(30);
            builder.Property(x => x.IsSigned).HasColumnName("is_signed").HasColumnType("bit").HasMaxLength(30);
            builder.Property(x => x.DateSigned).HasColumnName("date_signed").HasColumnType("datetime");
            builder.Property(x => x.SectionCode).HasColumnName("section_code").HasColumnType("nchar(2)").HasMaxLength(2);

            builder.HasOne(x => x.CovidQuestionsApi).WithOne(x => x.Form).HasForeignKey<FormApi>(x => x.FormId);
            builder.HasOne(x => x.ScoutSection).WithMany(y => y.Forms).HasForeignKey(z => z.SectionCode);
        }
    }
}
