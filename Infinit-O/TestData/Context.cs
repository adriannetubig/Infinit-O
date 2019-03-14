using System.Data.Entity;
using TestData.Entities;

namespace TestData
{
    public class Context : DbContext
    {
        public Context() : base("Test")
        {
            if (!Database.Exists())
            {
                Database.SetInitializer(new DBInitializer());
            }
        }

        public DbSet<School> Schools { get; set; }
    }
}
