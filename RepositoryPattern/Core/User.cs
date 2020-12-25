using System.ComponentModel.DataAnnotations;

namespace RepositoryPattern.Core
{
    public class User : BaseEntity
    {
        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }

        public string Email { get; set; }
    }
}
