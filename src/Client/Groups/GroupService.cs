using Client.Extensions;
using Shared.Groups;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Client.Groups
{
    public class GroupService : IGroupService
    {
        private readonly HttpClient _httpClient;
        private const string endpoint = "api/group";

        public GroupService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<GroupResponse.GetIndex> GetIndexAsync(GroupRequest.GetIndex request)
        {
            var queryParameters = request.GetQueryString();
            var response = await _httpClient.GetFromJsonAsync<GroupResponse.GetIndex>($"{endpoint}?{queryParameters}");
            return response;
        }
    }
}
