using ClassMates;
using ClassMates.InterFaces; 
var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddTransient<IAllPerson, DataBase>();
builder.Services.AddControllersWithViews();
builder.Services.AddMvc();
builder.Services.AddTransient<IAllPerson, DataBase>();

var app = builder.Build();
app.UseStaticFiles();
app.MapControllerRoute
    (
    name: "default",
    pattern: "{controller=MainHub}/{action=MainPage}/{id?}"
    ); 
app.Run();
