using Microsoft.EntityFrameworkCore;
using ScoutAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoutAPI.Repository
{
    public class FormContext : DbContext, IFormContext
    {

        public FormContext(DbContextOptions<FormContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new FormMap());
            builder.ApplyConfiguration(new CovidQuestionsMap());
            builder.ApplyConfiguration(new ScoutSectionMap());
        }

        public async Task SaveChangesAsync()
        {
            await base.SaveChangesAsync();
        }

        public DbSet<FormApi> Forms { get; set; }

        public DbSet<CovidQuestionsApi> CovidQuestions { get; set; }

        public DbSet<ScoutSection> ScoutSections { get; set; }
    }
}
