
using System.ComponentModel.DataAnnotations;

namespace AuthenticationManyToManyProject.Core.Entities.Common
{
    public class BaseEntity 
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual DateTime UpdatedDate { get; set; }
    }
}
