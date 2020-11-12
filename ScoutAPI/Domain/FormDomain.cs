using ScoutAPI.Models;
using ScoutAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoutAPI.Domain
{
    public class FormDomain : IFormDomain
    {
        private readonly IFormRepository _formRepository;

        public FormDomain(IFormRepository formRepository)
        {
            _formRepository = formRepository;
        }

        public async Task AddFormRecord(InputForm inputForm)
        {
            var formId = await _formRepository.GetNextFormId();
            var questionId = await _formRepository.GetNextQuestionId();

            var form = new FormApi()
            {
                FormId = formId,
                FirstName = inputForm.FirstName,
                Surname = inputForm.Surname,
                IsSigned = inputForm.IsSigned,
                DateSigned = inputForm.DateSigned,
                CovidQuestionsApi = new CovidQuestionsApi()
                {
                    QuestionId = questionId,
                    FormId = formId,
                    CloseContact = inputForm.CloseContact, 
                    SymptomsInd = inputForm.SymptomsInd,
                    DiagnosedInd = inputForm.DiagnosedInd,
                    SelfIsolatedInd = inputForm.SelfIsolatedInd,
                    CocoonInd = inputForm.CocoonInd,
                    AtRiskInd = inputForm.AtRiskInd,
                },
                SectionCode = inputForm.ScoutSection != null ? inputForm.ScoutSection : "SS",
            };

            await _formRepository.AddFormRecord(form);
        }

        public async Task<IEnumerable<IFormReturnEntity>> GetAllForms()
        {
            var formsList = new List<IFormReturnEntity>();
            var forms = await _formRepository.GetAllForms();

            foreach(var form in forms)
            {
                formsList.Add(new FormReturnEntity(form));
            }

            return formsList;
        }

        public async Task<IFormApi> GetFormById(int id)
        {
            return await _formRepository.GetFormById(id); 
        }
    }
}
