// ---------- Minimal Api приложение ---------- 
// ToDO:
// - Ознакомиться с Codestyle ([rev. 3.2] .docx)
// - реализовать подход Code First (Entity Framework 6.x)
// - Schema swagger (???)
// ---------- ---------------------- ---------- 

using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Добавляем службы в контейнер.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Прикручиваем Swagger.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Endpoints
app.MapGet("/", () =>
{
    StringBuilder response = new("Hello World!\n");
    response.Append(DateTime.Now);

    return response.ToString();
});

app.MapGet("/GetDateCurrent", () =>
    DateTime.Now);

// Запуск приложения
app.Run();