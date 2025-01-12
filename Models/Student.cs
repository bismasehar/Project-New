using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Project_New.Models
{
    public class Student
    {
        [Key]
        public int RollNo { get; set; }
        public string name { get; set; }
        public string DOB { get; set; }
        public string ContactNo { get; set; }

    }
}
