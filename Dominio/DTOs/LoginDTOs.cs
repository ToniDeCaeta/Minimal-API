namespace MinimalApi.Dominio.DTOs;
//DTO Documento de transferencia entre os controllers
public class LoginDTO 
{
        

    public LoginDTO(string email, string senha)
    {
        Email = email;
        Senha = senha;
    }
    
    public string Email { get; set; } = default!;
    public string Senha { get; set; } = default!;
}