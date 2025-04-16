using System.ComponentModel.DataAnnotations;

namespace DemoRazorApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateRegister { get; set; } = DateTime.Now;

        public bool Active { get; set; } = true;


    }
}
