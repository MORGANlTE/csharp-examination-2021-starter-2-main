using Domain.Common;

namespace Domain.Groups
{
    public class GroupFaker : EntityFaker<Group>
    {
        public GroupFaker(bool hasRandomId = true) : base(hasRandomId)
        {
            CustomInstantiator(f => new Group(f.Commerce.Department()));
        }
    }
}
