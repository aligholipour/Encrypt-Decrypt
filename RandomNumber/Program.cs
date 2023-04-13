using RandomNumber.RandomNumberUtilities;
using RandomNumber.Symmetric;

//var byteRandomNumber = RandomNumberCrypto.GenerateByteRandomNumberCrypto(10);
//var stringRandomNumber = RandomNumberCrypto.GenerateStringRandomNumberCrypto(10);
//var guidRandomNumber = RandomNumberCrypto.GenerateGUIDRandomNumberCrypto();

//Console.WriteLine($"Generate a random 'String' number: {stringRandomNumber}");
//Console.WriteLine($"Generate a random 'GUID' number: {guidRandomNumber}");

string plainText = "This is a test string";

byte[] key, iv;

SymmetricAes.GenerateKeyAndIV(out key, out iv);

byte[] encrypted = SymmetricAes.Encrypt(plainText, key, iv);

string decrypred = SymmetricAes.Decrypt(encrypted, key, iv);

Console.WriteLine($"plainText: {plainText}");

Console.WriteLine($"encrypted: {Convert.ToBase64String(encrypted)}");

Console.WriteLine($"decrypred: {decrypred}");