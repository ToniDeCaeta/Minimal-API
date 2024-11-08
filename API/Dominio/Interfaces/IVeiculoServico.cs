using MinimalApi.Dominio.DTOs;
using MinimalApi.Dominio.Entidades;

namespace MinimalApi.Dominio.Interfaces;

public interface IVeiculoServico
{
     List<Veiculo>? Todos(int? pagina = 1, string? nome = null, string? marca = null);
     Veiculo? BuscaPorId( int id); //somente o BuscaPorId precisa do tipo Veiculo, pois precisa desse tipo de retorno. 

     void Incluir( Veiculo veiculo);

     void Atualizar( Veiculo veiculo);

     void Apagar ( Veiculo veiculo);

}