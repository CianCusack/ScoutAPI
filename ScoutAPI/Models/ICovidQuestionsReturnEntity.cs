using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoutAPI.Models
{
    public interface ICovidQuestionsReturnEntity
    {
        bool CloseContactIndicated { get; }

        bool SymptomsIndicated { get; }

        bool DiagnosedIndicated { get; }

        bool SelfIsolateIndicated { get; }

        bool CocoonIndicated { get; }

        bool AtRiskGroupIndicated { get; }
    }
}
