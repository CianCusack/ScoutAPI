using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoutAPI.Domain
{
    public interface IFormApi
    {
        int FormId { get; set; }

        string FirstName { get; set; }

        string Surname { get; set; }

        bool IsSigned { get; set; }

        DateTime DateSigned { get; set; }

        CovidQuestionsApi CovidQuestionsApi { get; set; }
    }
}
