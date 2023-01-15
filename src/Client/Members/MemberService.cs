using Client.Extensions;
using Shared.Members;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Client.Members
{
    public class MemberService : IMemberService
    {
        private readonly HttpClient _httpClient;
        private const string endpoint = "api/member";

        public MemberService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<MemberResponse.GetIndex> GetIndexAsync(MemberRequest.GetIndex request)
        {
            System.Console.WriteLine(request.SearchTerm + "IDFK");
            var response = await _httpClient.GetFromJsonAsync<MemberResponse.GetIndex>($"{endpoint}?searchTerm={request.SearchTerm}");
			return response;
        }

        public async Task<MemberResponse.Create> CreateAsync(MemberRequest.Create request)
        {
            var response = await _httpClient.PostAsJsonAsync(endpoint, request);
            return await response.Content.ReadFromJsonAsync<MemberResponse.Create>();
        }
    }
}
