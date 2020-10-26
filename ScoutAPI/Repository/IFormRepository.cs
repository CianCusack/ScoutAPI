using ScoutAPI.Domain;
using ScoutAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoutAPI.Repository
{
    public interface IFormRepository
    {
        Task<IFormApi> GetFormById(int id);
        Task<IEnumerable<IFormApi>> GetAllForms();
        Task AddFormRecord(FormApi formApi);
        Task<int> GetNextFormId();
        Task<int> GetNextQuestionId();
    }
}
