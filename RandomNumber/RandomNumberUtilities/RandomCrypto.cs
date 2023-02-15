using System.Security.Cryptography;

namespace RandomNumber.RandomNumberUtilities
{
    public static class RandomNumberCrypto
    {
        private static readonly string randomGUID = Guid.NewGuid().ToString();

        public static byte[] GenerateByteRandomNumberCrypto(int length)
        {
            using var cryptoPovider = RandomNumberGenerator.Create();

            var randomNumber = new byte[length];
            cryptoPovider.GetBytes(randomNumber);

            return randomNumber;
        }

        public static string GenerateStringRandomNumberCrypto(int length)
        {
            using var cryptoPovider = RandomNumberGenerator.Create();

            var randomNumber = new byte[length];

            cryptoPovider.GetBytes(randomNumber);

            return new string(randomNumber.Select(x => randomGUID[x % randomGUID.Length]).ToArray());
        }
    }
}
