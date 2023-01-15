using FluentValidation;

namespace Shared.Members
{
    public static class MemberDto
    {
        public class Index
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string TwitterHandle { get; set; }
        }

        public class Mutate
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string TwitterHandle { get; set; }
            public int GroupId { get; set; }
            public class Validator : AbstractValidator<Mutate>
            {
                public Validator()
                {
                    RuleFor(x => x.FirstName).NotEmpty().MaximumLength(100);
                    RuleFor(x => x.LastName).NotEmpty().MaximumLength(100);
                    RuleFor(x => x.Email).NotEmpty().EmailAddress();
                    RuleFor(x => x.GroupId).NotEmpty().GreaterThan(0);
                }
            }
        }
    }
}
