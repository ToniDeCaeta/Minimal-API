//teremos modelos de vizualizações, para retornar resultados em Json
namespace MinimalApi.Dominio.ModelViews;

public struct ErrosDeValidacao
{
    public List<string> Mensagens { get; set;}
    
}