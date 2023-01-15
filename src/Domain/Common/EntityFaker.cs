using Bogus;

namespace Domain.Common
{
    public abstract class EntityFaker<T> : Faker<T> where T : Entity
    {
        public EntityFaker(bool hasRandomId = true)
        {
            UseSeed(1337);
            if (hasRandomId)
            {
                RuleFor(x => x.Id, f => ++f.IndexVariable);
            }
        }
    }
}
