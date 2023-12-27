
using AuthenticationManyToManyProject.Core.Entities.Common;

namespace AuthenticationManyToManyProject.Core.Entities
{
    public class Group : BaseEntity
    {
        public Group()
        {
            RoleGroups= new HashSet<RoleGroup>();
        }
        public string Name { get; set; }
        public virtual ICollection<RoleGroup> RoleGroups { get; set; }
    }
}
