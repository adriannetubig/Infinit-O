using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestData.Models;

namespace TestData.Services
{
    public class BusinessServiceSchools : IBusinessServiceSchools
    {
        private readonly IDataServiceSchools _iDataServiceSchools;
        private readonly IMapper _mapper;

        public BusinessServiceSchools(IDataServiceSchools iDataServiceSchools, IMapper mapper)
        {
            _iDataServiceSchools = iDataServiceSchools;
            _mapper = mapper;
        }

        public async Task Create(School school)
        {
            var entitySchool = _mapper.Map<Entities.School>(school);
            await _iDataServiceSchools.Create(entitySchool);
        }

        public async Task<List<School>> Read()
        {
            var entitySchools = await _iDataServiceSchools.Read();
            return _mapper.Map<List<School>>(entitySchools);
        }

        public async Task Update(School school)
        {
            var entitySchool = _mapper.Map<Entities.School>(school);
            await _iDataServiceSchools.Update(entitySchool);
        }

        public async Task Delete(int schoolId)
        {
            await _iDataServiceSchools.Delete(schoolId);
        }
    }
}
