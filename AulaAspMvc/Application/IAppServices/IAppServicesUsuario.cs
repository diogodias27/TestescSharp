using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AppServices
{
    public interface IAppServicesUsuario 
    {
        Usuario LoginUsuario(string sSenha, string sUsuario);
    }
}
