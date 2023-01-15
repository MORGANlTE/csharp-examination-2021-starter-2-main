using Microsoft.AspNetCore.Components;
using Shared.Members;

namespace Client.Members.Components
{
    public partial class MemberListItem
    {
        [Parameter] public MemberDto.Index Member { get; set; }
    }
}
