using System.Collections.Generic;

namespace Shared.Groups
{
    public static class GroupResponse
    {
        public class GetIndex
        {
            public List<GroupDto.Index> Groups { get; set; } = new();
        }
    }
}
