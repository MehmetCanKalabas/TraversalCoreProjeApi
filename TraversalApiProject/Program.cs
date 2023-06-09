
var builder = WebApplication.CreateBuilder(args);

// Hizmetleri yapılandırma
builder.Services.AddControllers();

// CORS yapılandırmasını ekleme
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

// CORS politikasını etkinleştirme
app.UseCors("TraversalApiCors");

app.UseAuthorization();

app.MapControllers();

app.Run();