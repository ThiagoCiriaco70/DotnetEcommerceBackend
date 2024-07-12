using GameStoreAPI.Data;
using GameStoreAPI.Dtos;
using GameStoreAPI.Endpoints;

var builder = WebApplication.CreateBuilder(args);

//get conn string from config file 
var connString = builder.Configuration.GetConnectionString("GameStore");
builder.Services.AddSqlite<GameStoreContext>(connString);

var app = builder.Build();

app.MapGamesEndpoints();
app.MapGenresEndpoints();

await app.MigrateDbAsync();

app.Run();