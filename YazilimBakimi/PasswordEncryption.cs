using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography; 

namespace YazilimBakimi
{
    class PasswordEncryption
    {
        public String Md5(String sifre) {
            MD5 md5 = System.Security.Cryptography.MD5.Create();

            byte[] sifrebyt = new UTF8Encoding().GetBytes(sifre);

            sifrebyt = md5.ComputeHash(sifrebyt);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < sifrebyt.Length; i++)
            {
                sb.Append(sifrebyt[i].ToString("X2"));
            }

            return sb.ToString();
        }
        
}
}
