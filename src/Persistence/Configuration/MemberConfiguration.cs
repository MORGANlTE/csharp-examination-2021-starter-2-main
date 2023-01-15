using Domain.Members;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class MemberConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
			//save lastname and firstname in their own respective columns

            builder.OwnsOne(x => x.Name, name =>
            {
                name.Property(name => name.FirstName).IsRequired().HasMaxLength(100);
                name.Property(name => name.LastName).IsRequired().HasMaxLength(100);
            });
			builder.Property(m => m.Email).IsRequired();
			builder.HasOne(x => x.Group).WithMany(x => x.Members).OnDelete(DeleteBehavior.Cascade);
			//builder.Ignore(m => m.Name);
		}
    }
}
