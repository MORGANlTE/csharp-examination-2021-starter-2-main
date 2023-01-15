using System;
using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using Shared.Groups;
using Shared.Members;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Client.Members
{
	public partial class Create
	{
		[Inject] public IGroupService GroupService { get; set; }

		private List<GroupDto.Index> groups = new();
		private MemberDto.Mutate member = new();
		[Inject] public IMemberService MemberService { get; set; }
		[Inject] public NavigationManager NavigationManager { get; set; }
		[Inject] public IToastService ToastService { get; set; }

		protected override async Task OnInitializedAsync()
		{
			await GetGroupsAsync();
		}

		private async Task CreateMemberAsync()
		{
			var req = new MemberRequest.Create()
			{
				Member = member
			};

			await MemberService.CreateAsync(req);
			NavigationManager.NavigateTo("/");

			ToastService.ShowSuccess($"{member.FirstName} {member.LastName} successfully added");

		}

		private async Task GetGroupsAsync()
		{
			GroupRequest.GetIndex request = new();
			var response = await GroupService.GetIndexAsync(request);
			groups = response.Groups;
		}
	}
}
