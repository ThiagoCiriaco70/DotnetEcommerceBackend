using GameStoreAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStoreAPI.Data;

//intermediary bt db and program
public class GameStoreContext(DbContextOptions<GameStoreContext> options) : DbContext(options)
{
    public DbSet<Game> Games => Set<Game>();
    public DbSet<Genre> Genres => Set<Genre>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Genre>().HasData(
          new {Id = 1, Name = "Fighting"},
          new {Id = 2, Name = "Sandbox"},
          new {Id = 3, Name = "Exploration"},
          new {Id = 4, Name = "Adventure"},
          new {Id = 5, Name = "Racing"},
          new {Id = 6, Name = "Metroidvania"}
        );
    }
}
