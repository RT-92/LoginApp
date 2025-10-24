using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginUsuarios
{
    using System;
    using System.Security.Cryptography;
    using System.Text;

    namespace LoginApp.Utils
    {
        
     
        public static class HashGenerator
        {
            
            /// Genera el hash SHA2_256 de una cadena usando Encoding.Unicode.
            /// Este encoding es compatible con NVARCHAR en SQL Server.
         
            public static string GenerateSHA256(string input)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytes = Encoding.Unicode.GetBytes(input); // clave para compatibilidad con SQL Server
                    byte[] hashBytes = sha256.ComputeHash(bytes);

                    StringBuilder sb = new StringBuilder();
                    foreach (byte b in hashBytes)
                        sb.Append(b.ToString("X2")); // formato hexadecimal en mayúsculas

                    return sb.ToString();
                }
            }


            /// Verifica si el texto plano coincide con el hash esperado.

            ///  "input" Texto plano
            /// "expectedHash" Hash esperado
            /// True si coincide, false si no coincide
            public static bool VerifySHA256(string input, string expectedHash)
            {
                string hash = GenerateSHA256(input);
                return string.Equals(hash, expectedHash, StringComparison.OrdinalIgnoreCase);
            }
        }
    }

}
