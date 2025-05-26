using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
//using restApi.DB;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseInMemoryDatabase("InMemoryDb"));

// Configure Identity to use the in-memory database
//builder.Services.AddIdentity<IdentityUser, IdentityRole>()
//    .AddEntityFrameworkStores<ApplicationDbContext>()
//    .AddDefaultTokenProviders();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();



var app = builder.Build();

app.UseHsts();//upozori korisnika da koristi secure

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapControllers();

app.UseHttpsRedirection();

//using (var scope = app.Services.CreateScope())
//{
//    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

//    // Define roles you want to support
//    string[] roles = new[] { "Reader", "Admin", "User" };

//    foreach (var role in roles)
//    {
//        var exists = await roleManager.RoleExistsAsync(role);
//        if (!exists)
//        {
//            await roleManager.CreateAsync(new IdentityRole(role));
//        }
//    }
//}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();


app.Run();
