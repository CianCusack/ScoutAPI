using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoutAPI.Domain
{
    public class ScoutSection
    {
        public string SectionCode { get; set; }

        public string SectionDescription { get; set; }

        public ICollection<FormApi> Forms { get; set; }
    }
}
