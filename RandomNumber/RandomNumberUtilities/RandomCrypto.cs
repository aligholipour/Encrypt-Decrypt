using System.Security.Cryptography;

namespace RandomNumber.RandomNumberUtilities
{
    public static class RandomNumberCrypto
    {
        public static byte[] GenerateByteRandomNumberCrypto(int length)
        {
            using var cryptoPovider = RandomNumberGenerator.Create();

            var randomNumber = new byte[length];
            cryptoPovider.GetBytes(randomNumber);

            return randomNumber;
        }
    }
}
