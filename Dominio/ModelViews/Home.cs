//teremos modelos de vizualizações, para retornar resultados em Json
namespace MinimalApi.Dominio.ModelViews;

public struct Home
{
    public string Mensagem { get => "Bem vindo a API de veiculos - Minimal API";}
    public string Doc { get => "/swagger";}
}