using Domain.Common;
using Ardalis.GuardClauses;
using System.Collections.Generic;

namespace Domain.Members
{
    public class MemberName : ValueObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private MemberName() { }

        public MemberName(string firstName, string lastName)
        {
            FirstName = Guard.Against.NullOrEmpty(firstName, nameof(firstName));
            LastName = Guard.Against.NullOrEmpty(lastName, nameof(lastName));
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return FirstName.ToLower();
            yield return LastName.ToLower();
        }
    }
}
