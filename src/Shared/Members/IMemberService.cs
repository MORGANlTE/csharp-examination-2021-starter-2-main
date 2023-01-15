using System.Threading.Tasks;

namespace Shared.Members
{
    public interface IMemberService
    {
        Task<MemberResponse.GetIndex> GetIndexAsync(MemberRequest.GetIndex request);
        Task<MemberResponse.Create> CreateAsync(MemberRequest.Create request);
    }
}
