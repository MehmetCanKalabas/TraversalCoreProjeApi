
var builder = WebApplication.CreateBuilder(args);

// Hizmetleri yap�land�rma
builder.Services.AddControllers();

// CORS yap�land�rmas�n� ekleme
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("TraversalApiCors", opts =>
    {
        opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();

// CORS politikas�n� etkinle�tirme
app.UseCors("TraversalApiCors");

app.UseAuthorization();

app.MapControllers();

app.Run();