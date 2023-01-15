using Shared.Members;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        [HttpGet]
        public Task<MemberResponse.GetIndex> GetIndexAsync([FromQuery] string? SearchTerm)
        {
            return _memberService.GetIndexAsync(new MemberRequest.GetIndex() { SearchTerm = SearchTerm});
        }

        [HttpPost]
        public Task<MemberResponse.Create> CreateAsync([FromBody] MemberRequest.Create request)
        {
            return _memberService.CreateAsync(request);
        }
    }
}
