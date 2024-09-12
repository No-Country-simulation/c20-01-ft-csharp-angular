using Microsoft.EntityFrameworkCore;
using WebApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Configurar CORS para permitir que Angular acceda al backend
builder.Services.AddCors(options =>
{
	options.AddPolicy("AllowAngularApp",
		policy =>
		{
			policy.WithOrigins("http://localhost:4200") // La URL de tu aplicación Angular
				  .AllowAnyHeader()
				  .AllowAnyMethod();
		});
});

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
	options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Usar CORS
app.UseCors("AllowAngularApp");

/*
using (var scope = app.Services.CreateScope() )
{
	var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
	context.Database.Migrate();
}*/

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
