using ScoutAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ScoutAPI.Models
{
    public class FormReturnEntity : IFormReturnEntity, IReturnEntity
    {
        private IFormApi _formApi;

        public FormReturnEntity(IFormApi api)
        {
            _formApi = api;
        }
                
        public string FirstName 
        {
            get
            {
                return _formApi.FirstName;
            }
        }

        public string Surname 
        { 
            get
            {
                return _formApi.Surname;
            }
        }

        public bool IsSigned
        {
            get
            {
                return _formApi.IsSigned;
            }
        }

        public string DateSigned
        {
            get
            {
                return String.Format("{0: yyyyMMdd}", _formApi.DateSigned);
            }
        }

        public string ScoutSection
        {
            get
            {
                return _formApi.ScoutSection != null
                    ? _formApi.ScoutSection.SectionDescription
                    : string.Empty;
            }
        }

        public ICovidQuestionsReturnEntity CovidQuestions
        {
            get
            {
                return new CovidQuestionsReturnEntity(_formApi.CovidQuestionsApi);
            }
        }
    }
}
