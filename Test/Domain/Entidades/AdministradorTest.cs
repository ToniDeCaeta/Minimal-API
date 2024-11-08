using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class AdministradorTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        //Arrange = todas as variaveis wue iremos criar para fazer validações
        var adm = new Administrador();

        //Act = Ações wue iremos executar
        adm.Id = 1;  //testando get
        adm.Email = "teste@teste.com";
        adm.Senha = "teste";
        adm.Perfil = "Adm";

        //Assert = validção dos dados
        Assert.AreEqual(1, adm.Id); //testando set
        Assert.AreEqual("teste@teste.com", adm.Email);
        Assert.AreEqual( "teste", adm.Senha);
        Assert.AreEqual("Adm", adm.Perfil);
    }
}