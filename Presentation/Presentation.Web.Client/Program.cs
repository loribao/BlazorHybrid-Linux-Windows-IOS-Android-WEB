using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Presentation.Shared.Services;
using Presentation.Web.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the Presentation.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

await builder.Build().RunAsync();
