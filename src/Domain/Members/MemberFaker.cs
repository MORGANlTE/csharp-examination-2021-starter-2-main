using Domain.Common;
using Domain.Groups;

namespace Domain.Members
{
    public class MemberFaker : EntityFaker<Member>
    {
        public MemberFaker(bool hasRandomId = true) : base(hasRandomId)
        {
            var groups = new GroupFaker(hasRandomId).Generate(10);
            CustomInstantiator(f => new Member(
                new MemberNameFaker(), f.Internet.Email(),
                $"@{f.Internet.UserName()}", f.PickRandom(groups)
            ));
        }
    }
}
