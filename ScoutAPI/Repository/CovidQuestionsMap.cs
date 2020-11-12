using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScoutAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoutAPI.Repository
{
    public class CovidQuestionsMap : IEntityTypeConfiguration<CovidQuestionsApi>
    {
        public void Configure(EntityTypeBuilder<CovidQuestionsApi> builder)
        {
            builder.ToTable("Covid_Questions", "dbo");
            builder.HasKey(x => x.QuestionId);

            builder.Property(x => x.QuestionId).HasColumnName("question_id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.FormId).HasColumnName("form_id").HasColumnType("int").IsRequired();
            builder.Property(x => x.CloseContact).HasColumnName("close_contact_ind").HasColumnType("bit");
            builder.Property(x => x.SymptomsInd).HasColumnName("symptoms_ind").HasColumnType("bit");
            builder.Property(x => x.DiagnosedInd).HasColumnName("diagnosed_ind").HasColumnType("bit");
            builder.Property(x => x.SelfIsolatedInd).HasColumnName("self_isolate_ind").HasColumnType("bit");
            builder.Property(x => x.CocoonInd).HasColumnName("cocoon_ind").HasColumnType("bit");
            builder.Property(x => x.AtRiskInd).HasColumnName("at_risk_ind").HasColumnType("bit");
        }
    }
}
