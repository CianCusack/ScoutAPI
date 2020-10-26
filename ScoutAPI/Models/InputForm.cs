using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoutAPI.Models
{
    public class InputForm
    {
        public int FormId { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public bool IsSigned { get; set; }

        public DateTime DateSigned { get; set; }
        public int QuestionId { get; set; }

        public bool CloseContact { get; set; }

        public bool SymptomsInd { get; set; }
    }
}
