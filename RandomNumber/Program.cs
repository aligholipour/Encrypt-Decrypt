using RandomNumber.RandomNumberUtilities;

var byteRandomNumber = RandomNumberCrypto.GenerateByteRandomNumberCrypto(10);
var stringRandomNumber = RandomNumberCrypto.GenerateStringRandomNumberCrypto(10);
var guidRandomNumber = RandomNumberCrypto.GenerateGUIDRandomNumberCrypto();

Console.WriteLine($"Generate a random 'String' number: {stringRandomNumber}");
Console.WriteLine($"Generate a random 'GUID' number: {guidRandomNumber}");