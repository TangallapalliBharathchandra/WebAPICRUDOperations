using System.ComponentModel.DataAnnotations;

namespace WebAPICRUDOperations.Models
{
    public class OurHero
    {
        [Key]
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public bool isActive { get; set; } = true;
    }
}
