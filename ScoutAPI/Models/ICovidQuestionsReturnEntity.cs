using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoutAPI.Models
{
    public interface ICovidQuestionsReturnEntity
    {
        bool CloseContact { get; }

        bool SymptomsIndicated { get; }
    }
}
