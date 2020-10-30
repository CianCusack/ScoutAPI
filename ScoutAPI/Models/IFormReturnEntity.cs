using ScoutAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ScoutAPI.Models
{
    public interface IFormReturnEntity : IReturnEntity
    {
        string FirstName { get; }

        string Surname { get; }

        bool IsSigned { get; }

        string DateSigned { get; }

        string ScoutSection { get; }

        ICovidQuestionsReturnEntity CovidQuestions { get; }
    }
}
