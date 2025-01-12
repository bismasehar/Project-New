using System.ComponentModel.DataAnnotations;

namespace Project_New.Models
{
    public class Login
    {
        [Key]
        public string name{ get; set; }
        public string email { get; set; }
    }
}
