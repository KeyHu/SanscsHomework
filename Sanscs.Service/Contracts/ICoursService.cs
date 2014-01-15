using Sanscs.Model;
using System.Collections.Generic;

namespace Sanscs.Service.Contracts
{
    public interface ICoursService
    {
        List<cours> GetCoursCategories();
    }
}
