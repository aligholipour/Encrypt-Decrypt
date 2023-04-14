
using Symmetric.SymmetricUtilities;

string plainText = "This is a test string";

byte[] key, iv;

SymmetricAes.GenerateKeyAndIV(out key, out iv);

byte[] encrypted = SymmetricAes.Encrypt(plainText, key, iv);

string decrypred = SymmetricAes.Decrypt(encrypted, key, iv);

Console.WriteLine($"plainText: {plainText}");

Console.WriteLine($"encrypted: {Convert.ToBase64String(encrypted)}");

Console.WriteLine($"decrypred: {decrypred}");
