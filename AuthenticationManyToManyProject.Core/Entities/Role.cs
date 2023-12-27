

using AuthenticationManyToManyProject.Core.Entities.Common;

namespace AuthenticationManyToManyProject.Core.Entities
{
    public class Role : BaseEntity
    {
        public Role()
        {
            RoleGroups = new List<RoleGroup>();
        }
        public string Name { get; set; }
        public virtual ICollection<RoleGroup> RoleGroups { get; set; }

    }
}
