using System.ComponentModel.DataAnnotations;

namespace Hello.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Address { get; set; }

        public int Phone_number { get; set; }

        public int Citizenship_number{ get; set;}

        
    }
}
