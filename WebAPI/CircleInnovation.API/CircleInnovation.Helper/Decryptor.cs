using System;
using System.Configuration;
using System.Security.Cryptography;

namespace CircleInnovation.Helper
{
    public static class Decryptor
    {
        public static string Decrypt(this string text)
        {
            byte[] key = System.Text.Encoding.ASCII.GetBytes(ConfigurationManager.AppSettings["EncryptionKey"].ToString());
            byte[] iv = System.Text.Encoding.ASCII.GetBytes(ConfigurationManager.AppSettings["EncryptionIv"].ToString());

            SymmetricAlgorithm algorithm = DES.Create();
            ICryptoTransform transform = algorithm.CreateDecryptor(key, iv);
            byte[] inputbuffer = Convert.FromBase64String(text);
            byte[] outputBuffer = transform.TransformFinalBlock(inputbuffer, 0, inputbuffer.Length);
            return System.Text.Encoding.Unicode.GetString(outputBuffer);
        }
    }
}
