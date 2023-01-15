using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Shared.Groups;

namespace Services.Groups
{
    public class GroupService : IGroupService
    {
        private readonly ApplicationDbContext _dbContext;

        public GroupService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GroupResponse.GetIndex> GetIndexAsync(GroupRequest.GetIndex request)
        {
            GroupResponse.GetIndex response = new();

            response.Groups = await _dbContext.Groups
                .OrderBy(x => x.Name)
                .Select(x => new GroupDto.Index
                {
                    Id = x.Id,
                    Name = x.Name,
                }).ToListAsync();

            return response;
        }
    }
}
