using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using TestData.Entities;

namespace TestData.Services
{
    public class DataServiceSchools : IDataServiceSchools
    {
        public async Task Create(School school)
        {
            using (var context = new Context())
            {
                context.Schools.Add(school);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<School>> Read()
        {
            using (var context = new Context())
            {
                return await context.Schools.ToListAsync();
            }
        }

        public async Task Update(School school)
        {
            using (var context = new Context())
            {
                var currentSchool = context.Schools.Find(school.SchoolId);
                if (currentSchool == null)
                    return;

                context.Entry(currentSchool).CurrentValues.SetValues(school);
                await context.SaveChangesAsync();
            }
        }

        public async Task Delete(int schoolId)
        {
            using (var context = new Context())
            {
                var currentSchool = context.Schools.Find(schoolId);
                if (currentSchool == null)
                    return;

                context.Entry(currentSchool).State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }
        }
    }
}
