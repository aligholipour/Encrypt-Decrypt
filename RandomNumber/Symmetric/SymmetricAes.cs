using System.Security.Cryptography;
using System.Text;

namespace RandomNumber.Symmetric
{
    public class SymmetricAes
    {
        public static void GenerateKeyAndIV(out byte[] key, out byte[] iv)
        {
            using (Aes aes = Aes.Create())
            {
                key = aes.Key;
                iv = aes.IV;
            }
        }

        public static byte[] Encrypt(string plainText, byte[] key, byte[] iv)
        {
            byte[] encrypted;

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        byte[] data = Encoding.UTF8.GetBytes(plainText);

                        if (data is not null)
                        {
                            cs.Write(data, 0, data.Length);
                        }
                    }

                    encrypted = ms.ToArray();
                }
            }
            return encrypted;
        }

        public static string Decrypt(byte[] cipherText, byte[] key, byte[] iv)
        {
            string decrypted;

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream(cipherText))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            decrypted = sr.ReadToEnd();
                        }
                    }
                }
            }

            return decrypted;
        }
    }
}
