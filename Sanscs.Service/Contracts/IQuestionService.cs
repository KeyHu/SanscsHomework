using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sanscs.Model.DTO;

namespace Sanscs.Service.Contracts
{
    public interface IQuestionService
    {
        int SaveOrUpdateQuestion(QuestionDTO question);
    }
}
