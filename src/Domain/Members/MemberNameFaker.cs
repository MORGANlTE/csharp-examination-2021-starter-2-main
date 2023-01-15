using Bogus;

namespace Domain.Members
{
    public class MemberNameFaker : Faker<MemberName>
    {
        public MemberNameFaker()
        {
            var n = new Bogus.DataSets.Name();
            CustomInstantiator(f => new MemberName(n.FirstName(), n.LastName()));
        }
    }
}
