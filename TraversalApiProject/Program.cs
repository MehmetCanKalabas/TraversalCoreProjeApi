
var builder = WebApplication.CreateBuilder(args);

// Hizmetleri yapýlandýrma
builder.Services.AddControllers();

// CORS yapýlandýrmasýný ekleme
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

// CORS politikasýný etkinleþtirme
app.UseCors("TraversalApiCors");

app.UseAuthorization();

app.MapControllers();

app.Run();