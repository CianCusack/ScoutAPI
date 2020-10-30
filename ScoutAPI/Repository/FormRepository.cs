using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using ScoutAPI.Domain;
using ScoutAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoutAPI.Repository
{
    public class FormRepository : IFormRepository
    {
        private IFormContext _formContext;

        public FormRepository(IFormContext formContext)
        {
            _formContext = formContext;
        }

        public async Task AddFormRecord(FormApi formApi)
        {
            await _formContext.Forms.AddAsync(formApi);
            await _formContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<IFormApi>> GetAllForms()
        {
            return await _formContext
                .Forms
                .Include(x => x.CovidQuestionsApi)
                .Include(x => x.ScoutSection)
                .ToListAsync();
        }

        public async Task<IFormApi> GetFormById(int id)
        {
            return await _formContext
                .Forms
                .Include(x => x.CovidQuestionsApi)
                .FirstOrDefaultAsync(x => x.FormId == id);
        }

        public async Task<int> GetNextFormId()
        {
            return await _formContext.Forms.AnyAsync()
                ? await _formContext.Forms.Select(x => x.FormId).MaxAsync() + 1
                : 1;
        }

        public async Task<int> GetNextQuestionId()
        {
            return await _formContext.CovidQuestions.AnyAsync()
                ? await _formContext.CovidQuestions.Select(x => x.QuestionId).MaxAsync() + 1
                : 1;
        }
    }
}
