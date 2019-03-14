using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestData.Entities
{
    [Table("School")]
    public class School
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SchoolId { get; set; }

        public string SchoolName { get; set; }
        public string SchoolAddress { get; set; }
    }
}
