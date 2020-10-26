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

        public bool CloseContactIndicated
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

        public bool DiagnosedIndicated
        {
            get
            {
                return _covidQuestions != null
                    ? _covidQuestions.DiagnosedInd
                    : false;
            }
        }

        public bool SelfIsolateIndicated
        {
            get
            {
                return _covidQuestions != null
                    ? _covidQuestions.SelfIsolatedInd
                    : false;
            }
        }

        public bool CocoonIndicated
        {
            get
            {
                return _covidQuestions != null
                    ? _covidQuestions.CocoonInd
                    : false;
            }
        }

        public bool AtRiskGroupIndicated
        {
            get
            {
                return _covidQuestions != null
                    ? _covidQuestions.AtRiskInd
                    : false;
            }
        }
    }
}
