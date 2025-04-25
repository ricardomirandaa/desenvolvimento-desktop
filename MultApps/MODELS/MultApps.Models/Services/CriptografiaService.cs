using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models.Services
{
    public static class CriptografiaService
    {
        public static string Criptografar(string senha)
        {
            var senhaCripto = BCrypt.Net.BCrypt.HashPassword(senha);
            return senhaCripto;
        }
        public static bool Verificar(string senha, string senhaCriptografada)
        {
            BCrypt.Net.BCrypt.Verify(senha, senhaCriptografada);
            return BCrypt.Net.BCrypt.Verify(senha, senhaCriptografada);
        }
    }
}
