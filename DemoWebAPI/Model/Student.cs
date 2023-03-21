using System.ComponentModel.DataAnnotations;

namespace DemoWebAPI.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string StudentName { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
