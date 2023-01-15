using System.Threading.Tasks;

namespace Shared.Groups
{
    public interface IGroupService
    {
        Task<GroupResponse.GetIndex> GetIndexAsync(GroupRequest.GetIndex request);
    }
}
