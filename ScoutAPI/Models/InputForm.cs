using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoutAPI.Models
{
    public class InputForm
    {
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public bool IsSigned { get; set; }

        public DateTime DateSigned { get; set; }

        public bool CloseContact { get; set; }

        public bool SymptomsInd { get; set; }

        public bool DiagnosedInd { get; set; }

        public bool SelfIsolatedInd { get; set; }

        public bool CocoonInd { get; set; }

        public bool AtRiskInd { get; set; }

        public string ScoutSection { get; set; }
    }
}
