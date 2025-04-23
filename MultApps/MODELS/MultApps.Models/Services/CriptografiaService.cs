using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models.Services
{
    public class CriptografiaService
    {
        public string Criptografar(string senha)
        {
            var senhaCrpto = BCrypt.Net.BCrypt.HashPassword(senha);
            return senhaCrpto;
        }
        public string Verifiar(string senha, string senhaCriptografada)
        {
            BCrypt.Net.BCrypt.Verify(senha, senhaCriptografada);

        }
    }
}
