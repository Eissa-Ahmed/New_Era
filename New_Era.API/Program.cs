
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddAPIDependencyInjection()
    .AddCoreDependencyInjection()
    .AddInfrastructureDependencyInjection(builder.Configuration)
    .AddServicesDependencyInjection();

builder.Services.AddInfrastructureDependencyInjection(builder.Configuration);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseRequestLocalization();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
