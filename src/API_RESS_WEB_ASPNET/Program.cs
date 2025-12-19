using MiProyectoWeb;

var builder = WebApplication.CreateBuilder(args);

// ===================== SERVICES =====================
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirTodo", policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

var app = builder.Build();

// ===================== INIT DB =====================
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
DatabaseInitializer.Initialize(connectionString);

// ===================== PIPELINE =====================
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseCors("PermitirTodo");

app.UseAuthorization();

app.MapControllers();

app.Run();
