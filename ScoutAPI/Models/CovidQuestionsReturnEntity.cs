using ScoutAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoutAPI.Models
{
    public class CovidQuestionsReturnEntity : ICovidQuestionsReturnEntity
    {
        private ICovidQuestionsApi _covidQuestions;

        public CovidQuestionsReturnEntity(ICovidQuestionsApi covidQuestions)
        {
            _covidQuestions = covidQuestions;
        }

        public bool CloseContact
        {
            get
            {
                return _covidQuestions != null
                    ? _covidQuestions.CloseContact
                    : false;
            }
        }

        public bool SymptomsIndicated
        {
            get
            {
                return _covidQuestions != null 
                    ? _covidQuestions.SymptomsInd
                    : false;
            }
        }
    }
}
