using System.ComponentModel.DataAnnotations;

namespace RepositoryPattern.Core
{
    /// <summary>
    /// Base Entity
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Primary key identifier
        /// </summary>
        [Key]
        public int Id { get; set; }
    }
}
