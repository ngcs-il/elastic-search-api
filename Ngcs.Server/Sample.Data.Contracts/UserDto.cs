using System.ComponentModel.DataAnnotations;

namespace Sample.Data.Contracts
{
    public class UserDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
