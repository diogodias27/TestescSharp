using Domain.Entities;

namespace Domain.Interfaces.IServices
{
    public interface IserviceUsuario
    {
        Usuario LoginUsuario(string sSenha, string sUsuario);
    }
}
