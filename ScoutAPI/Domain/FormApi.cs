using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoutAPI.Domain
{
    public class FormApi : IFormApi
    {
        public int FormId { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public bool IsSigned { get; set; }

        public DateTime DateSigned { get; set; }

        public CovidQuestionsApi CovidQuestionsApi { get; set; }
    }
}
