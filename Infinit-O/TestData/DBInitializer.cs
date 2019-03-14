using System.Data.Entity;
using System.Linq;
using TestData.Entities;

namespace TestData
{
    public class DBInitializer : CreateDatabaseIfNotExists<Context>
    {
        public DBInitializer()
        {
        }
        protected override void Seed(Context context)
        {
            if (!context.Schools.Any(a => a.SchoolName == "School1"))
            {
                context.Schools.Add( new School { SchoolName = "School1", SchoolAddress = "School1Address" } );
                context.SaveChanges();
            }
            if (!context.Schools.Any(a => a.SchoolName == "School2"))
            {
                context.Schools.Add(new School { SchoolName = "School2", SchoolAddress = "School2Address" });
                context.SaveChanges();
            }
            if (!context.Schools.Any(a => a.SchoolName == "School3"))
            {
                context.Schools.Add(new School { SchoolName = "School3", SchoolAddress = "School3Address" });
                context.SaveChanges();
            }
        }
    }
}
