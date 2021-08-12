using Blazorise;
using Blazorise.Bulma;
using Blazorise.Icons.FontAwesome;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace UIBaseProject
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("#app");

			builder.Services.AddBlazorise(o =>
			{
				o.ChangeTextOnKeyPress = true;
			})
			.AddBulmaProviders()
			.AddFontAwesomeIcons();

			builder.Services.AddAuth0Authentication(o =>
			{
				builder.Configuration.Bind("Auth0", o.ProviderOptions);
			});

			await builder.Build().RunAsync();
		}
	}
}
