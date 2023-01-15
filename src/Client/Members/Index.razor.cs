using Microsoft.AspNetCore.Components;
using Shared.Members;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Client.Members
{
	public partial class Index
	{
		[Inject] public IMemberService MemberService { get; set; }

		private List<MemberDto.Index> members;
		private MemberRequest.GetIndex request = new();

		protected override async Task OnInitializedAsync()
		{
			await GetMembersAsync();
		}

		private async Task GetMembersAsync()
		{
			MemberRequest.GetIndex request = new();
			var response = await MemberService.GetIndexAsync(request);
			members = response.Members;
		}

		private async Task Zoek()
		{
			System.Console.WriteLine(request.SearchTerm + "FUCK YOU");
			var response = await MemberService.GetIndexAsync(request);
			members = response.Members;
		}
	}
}
