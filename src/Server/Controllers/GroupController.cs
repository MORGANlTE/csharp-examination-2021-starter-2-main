using Shared.Groups;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GroupController : ControllerBase
    {
        private readonly IGroupService _groupService;

        public GroupController(IGroupService groupService)
        {
            _groupService = groupService;
        }

        [HttpGet]
        public Task<GroupResponse.GetIndex> GetIndexAsync([FromQuery] GroupRequest.GetIndex request)
        {
            return _groupService.GetIndexAsync(request);
        }
    }
}
