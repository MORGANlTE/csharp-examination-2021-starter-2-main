using System.Collections.Generic;

namespace Shared.Members
{
    public static class MemberResponse
    {
        public class GetIndex
        {
            public List<MemberDto.Index> Members { get; set; } = new();
        }

        public class Create
        {
            public int MemberId { get; set; }
        }
    }
}
