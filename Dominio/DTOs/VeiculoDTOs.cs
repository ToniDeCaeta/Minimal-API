
namespace MinimalApi.Dominio.DTOs;

public record VeiculoDTO  //record é uma instancia menor que uma classe. 
{
    
    
    public string Nome { get; set; } = default!;
    
    public string Marca { get; set; } = default!;
    
    public int Ano { get; set; } = default!;

}
