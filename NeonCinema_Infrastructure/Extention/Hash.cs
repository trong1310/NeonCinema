using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace NeonCinema_Infrastructure.Extention
{
    public class Hash
    {
        private const string key = "h4mX#u2Dv@9s8FHg";

        public static string Encrypt(string password)
        {
            using (var aes = new AesManaged())
            {
                byte[] keyByte = Encoding.UTF8.GetBytes(key);
                byte[] a = new byte[aes.BlockSize / 8];
                byte[] passwordbyte = Encoding.UTF8.GetBytes(password);

                aes.Key = keyByte;
                aes.IV = a;
                aes.Mode = CipherMode.CBC;

                ICryptoTransform encryptor = aes.CreateEncryptor();
                byte[] encryptorbytes = encryptor.TransformFinalBlock(passwordbyte, 0, passwordbyte.Length);
                return Convert.ToBase64String(encryptorbytes);

            }

        }
        public static string Decrypt(string encryptedPassword)
        {
            using (var aes = new AesManaged())
            {
                byte[] keyBytes = Encoding.UTF8.GetBytes(key);
                byte[] iv = new byte[aes.BlockSize / 8];
                byte[] encryptedBytes = Convert.FromBase64String(encryptedPassword);

                aes.Key = keyBytes;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;

                ICryptoTransform decryptor = aes.CreateDecryptor();

                byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }
    }
}
