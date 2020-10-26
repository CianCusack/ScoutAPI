using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoutAPI.Domain
{
    public interface ICovidQuestionsApi
    {
        int QuestionId { get; set; }

        int FormId { get; set; }
        bool CloseContact { get; set; }
        bool SymptomsInd { get; set; }
        FormApi Form { get; set; }
        bool DiagnosedInd { get; set; }
        bool SelfIsolatedInd { get; set; }
        bool CocoonInd { get; set; }
        bool AtRiskInd { get; set; }
    }
}
