using Blazored.Toast;
using Client.Auth;
using Client.Groups;
using Client.Members;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Shared.Groups;
using Shared.Members;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<AuthenticationStateProvider, FakeAuthenticationProvider>();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<IGroupService, GroupService>();
            builder.Services.AddScoped<IMemberService, MemberService>();
			builder.Services.AddBlazoredToast();
			await builder.Build().RunAsync();
        }
    }
}
