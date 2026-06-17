using System.ComponentModel.DataAnnotations;

namespace chat.Models
{
    public class UserDetails
    {
        [Key]
        public int Id { get; set; }
        
        public required string Name { get; set; }
    }
}
