using AuthenticationManyToManyProject.Core.Entities.Common;


namespace AuthenticationManyToManyProject.Core.Entities
{
    public class RoleGroup : BaseEntity
    {
        public Guid RoleId { get; set; }
        public virtual Role Role { get; set; }
        public Guid GroupId { get; set; }
        public virtual Group Group { get; set; }
    }
}
