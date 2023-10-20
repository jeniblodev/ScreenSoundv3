using Microsoft.EntityFrameworkCore;
using ScreenSound.Shared.Modelos;

namespace ScreenSound.Shared.Context;

public class ScreenSoundContext: DbContext
{
    public DbSet<Artista> Artistas { get; set; }
    public DbSet<Musica> Musicas { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSound3;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        optionsBuilder.UseSqlServer(connectionString);
    }
}
