var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
    name: "searchbyid",
    pattern: "search/{id:int}",
    defaults: new { Controller = "Home", Action = "SearchById" }
    );
app.MapControllerRoute(
    name: "searchbycategorymaxprice",
    pattern: "home/{category}/{maxprice}/search",
    defaults: new { Controller = "Home", Action = "Search" }
    );
app.MapControllerRoute(
    name: "searchbytext",
    pattern: "search/{needle}",
    defaults: new { Controller = "Home", Action = "SearchByString" }
    );
app.MapControllerRoute(
    name: "showtext",
    pattern: "home/showtext/{text}",
    defaults: new {Controller = "Home", Action = "ShowText" }
    );
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
