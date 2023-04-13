using System.Security.Cryptography;

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
    }
}
