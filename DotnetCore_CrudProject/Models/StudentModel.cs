using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetCore_CrudProject.Models
{
    public class StudentModel
    {
        [Key]
        public int ID { get; set; }

        [Column("StudentName", TypeName = "varchar(100)")]
        public required string Name { get; set; }

        [Column("StudentGender", TypeName = "varchar(20)")]
        public required string Gender { get; set; }
        public int Age { get; set; }
        public int Standard { get; set; }
    }
}
