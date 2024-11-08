using MinimalApi.Dominio.Interfaces;
using MinimalApi.Dominio.DTOs;
using MinimalApi.Dominio.Entidades;
using MinimalApi.Infraestrutura.DB;
using Microsoft.EntityFrameworkCore;

namespace MinimalApi.Dominio.Servicos;

public class VeiculoServico : IVeiculoServico //implementar os metodos falantando, feitos em IVeiculoServico, pois foi gerado um contrato com a interface. 
{

    private readonly DbContexto _contexto;
    public VeiculoServico(DbContexto contexto)
    {
        _contexto = contexto;
    }



    public void Apagar(Veiculo veiculo)
    {
        _contexto.Veiculos.Remove(veiculo);
        _contexto.SaveChanges();
    }

    public void Atualizar(Veiculo veiculo)
    {
        _contexto.Veiculos.Update(veiculo);
        _contexto.SaveChanges();
    
    }

    public Veiculo? BuscaPorId(int id)
    {
        return _contexto.Veiculos.Where( v => v.Id == id).FirstOrDefault(); //v sendo veiculo?! apelido
    }

    public void Incluir(Veiculo veiculo)
    {
        _contexto.Veiculos.Add(veiculo);
        _contexto.SaveChanges();
    }

    public List<Veiculo>? Todos(int? pagina = 1, string? nome = null, string? marca = null)
    {
        var query = _contexto.Veiculos.AsQueryable(); //O  que é um AsQueryable(); ?
        if (!string.IsNullOrEmpty(nome))
        {
        query = query.Where( v => EF.Functions.Like(v.Nome.ToLower(), $"%{nome.ToLower()}%"));
        }


        int itensPorPagina = 10;
        if (pagina != null)
        {
        query = query.Skip(((int)pagina -1)* itensPorPagina).Take(itensPorPagina);
        }
        
        return query.ToList();
    }
}

