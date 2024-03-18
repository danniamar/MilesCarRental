using DataAccess;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MilesCarRental;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

/*builder.Services.AddDbContext<CarRentalContext>(options =>
  options.UseMongoDB(builder.Configuration.GetConnectionString("mongodb+srv://danniaadmin:YHoebqKKyHiegn57@mongobd1.0iswrxt.mongodb.net/MilesRentalCar"))
);*/

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
