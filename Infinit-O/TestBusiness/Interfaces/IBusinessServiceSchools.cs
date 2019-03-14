using System.Collections.Generic;
using System.Threading.Tasks;
using TestData.Models;

namespace TestData.Services
{
    public interface IBusinessServiceSchools
    {
        Task Create(School school);
        Task<List<School>> Read();
        Task Update(School school);
        Task Delete(int schoolId);
    }
}
