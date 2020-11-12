using ScoutAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoutAPI.Domain
{
    public interface IFormDomain
    {
        Task<IFormApi> GetFormById(int id);
        Task<IEnumerable<IFormReturnEntity>> GetAllForms();
        Task AddFormRecord(InputForm form);
        Task<IEnumerable<IFormApi>> GetFormsWithDates(DateTime fromDate, DateTime toDate);
    }
}
