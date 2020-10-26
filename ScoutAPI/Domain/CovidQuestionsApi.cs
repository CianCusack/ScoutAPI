using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoutAPI.Domain
{
    public class CovidQuestionsApi : ICovidQuestionsApi
    {
        public int QuestionId { get; set; }

        public int FormId { get; set;}

        public bool CloseContact { get; set; }

        public bool SymptomsInd { get; set; }

        public FormApi Form { get; set; }

        public bool DiagnosedInd { get; set; }

        public bool SelfIsolatedInd { get; set; }

        public bool CocoonInd { get; set; }

        public bool AtRiskInd { get; set; }
    }
}
