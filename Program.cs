using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Net;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(e=>{
    e.MapControllerRoute(name:"defautl",pattern:"{controller=Home}/{action=index}/{id?}");
});
// app.MapGet("/", () => "Hello World!");

app.Run();


