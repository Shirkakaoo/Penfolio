using Penfolio.Web;

var builder = WebApplication.CreateBuilder(args);

#region InjectServices

builder.Services
        .InjectControllers()
        .InjectAddEndpointsApiExplorer()
        .InjectSwaggerGen();

#endregion


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
        app.UseSwagger();
        app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
