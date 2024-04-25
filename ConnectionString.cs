using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Security.Cryptography;

namespace DWI
{
    class ConnectionString
    {

        public static string GetConnectionString()
        {
            string connection = string.Empty;
             connection = Decrypt(ConfigurationManager.ConnectionStrings["DWI.Properties.Settings.dwiDevConnectionString"].ConnectionString, "DWI");
            //connection = ConfigurationManager.ConnectionStrings["DWI.Properties.Settings.dwiDevConnectionString"].ConnectionString;
            return connection;

        }

        public static string Decrypt(string encrypt, string key)
        {
            using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
                {
                    byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
                    tripleDESCryptoService.Key = byteHash;
                    tripleDESCryptoService.Mode = CipherMode.ECB;
                    byte[] data = Convert.FromBase64String(encrypt);
                    return Encoding.UTF8.GetString(tripleDESCryptoService.CreateDecryptor().TransformFinalBlock(data, 0, data.Length));
                }
            }
        }
    
    }
}
