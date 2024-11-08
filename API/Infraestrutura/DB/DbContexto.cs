using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MinimalApi.Dominio.Entidades;

namespace MinimalApi.Infraestrutura.DB;




public class DbContexto : DbContext
{

    private readonly IConfiguration _configuracaoAppSettings;

    public DbContexto (IConfiguration configuracaoAppSettings) //CTRO
    {
        _configuracaoAppSettings = configuracaoAppSettings;
    }



    public DbSet<Administrador> Administradores {get; set;} =default!;

    public DbSet<Veiculo> Veiculos {get; set;} =default!;  //cada entidade tem um mapemaneto DbSet.


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administrador>().HasData(
            new Administrador
            {
                Id = 1,
                Email = "administrador@teste.com",
                Senha = "123456",
                Perfil = "Adm"
            }
        );
    }

    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // metodo padrao de configuração
    {

        var stringConexao = _configuracaoAppSettings.GetConnectionString("mysql")?.ToString();

        if(!optionsBuilder.IsConfigured)
        {
            if(!string.IsNullOrEmpty(stringConexao))
                {
                    optionsBuilder.UseMySql
                    (
                    stringConexao,
                    ServerVersion.AutoDetect(stringConexao)
                    );
                }
        }
    }
}