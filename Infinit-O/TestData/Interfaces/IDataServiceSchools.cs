using System.Collections.Generic;
using System.Threading.Tasks;
using TestData.Entities;

namespace TestData.Services
{
    public interface IDataServiceSchools
    {
        Task Create(School school);
        Task<List<School>> Read();
        Task Update(School school);
        Task Delete(int schoolId);
    }
}
