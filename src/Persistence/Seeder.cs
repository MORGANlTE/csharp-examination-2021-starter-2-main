using Domain.Members;
using System.Linq;

namespace Persistence
{
    public class Seeder
    {
        public static void Seed(ApplicationDbContext dbContext)
        {
            if (dbContext.Members.Any())
                return;

            var members = new MemberFaker(false).Generate(100);
            dbContext.Members.AddRange(members);
            dbContext.SaveChanges();
        }
    }
}
