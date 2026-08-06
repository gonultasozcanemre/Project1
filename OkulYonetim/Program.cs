// Uygulamayı kurmaya başla 
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// "Bu bir MVC uygulaması, Controller ve View Kullanacağım."
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// http:// ile gelen isteği https://'e yönlendir(güvenlik)
app.UseHttpsRedirection();
//Yönlendirme kullanılacak
app.UseRouting();

//Login Sistemi olacak
app.UseAuthorization();
// Varlıkların Statik haritası olacak.
app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Bolum}/{action=BolumListesi}/{id?}")
    .WithStaticAssets();


app.Run();
