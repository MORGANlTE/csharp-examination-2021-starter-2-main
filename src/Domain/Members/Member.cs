using Domain.Common;
using Domain.Groups;
using Ardalis.GuardClauses;

namespace Domain.Members
{
    public class Member : Entity 
    {
        public MemberName Name { get; set; }
        public string Email { get; set; }
        public string TwitterHandle { get; set; }
        public Group Group { get; set; }

        private Member() { }

        public Member(MemberName name, string email, string twitterHandle, Group group)
        {
            Name = Guard.Against.Null(name, nameof(name));
            Email = Guard.Against.NullOrEmpty(email, nameof(email));
            Group = Guard.Against.Null(group, nameof(group));
            TwitterHandle = twitterHandle;
        }
    }
}
