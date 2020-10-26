using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using ScoutAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoutAPI.Repository
{
    public interface IFormContext
    {
        DbSet<FormApi> Forms{ get; set; }

        DbSet<CovidQuestionsApi> CovidQuestions { get; set; }

        Task SaveChangesAsync();
    }
}
