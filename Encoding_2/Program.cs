using System;

namespace Encoding_2
{
  class Program
  {
    public static async Task Main(string[] args)
    {
      VigenereCipher vigenere = new VigenereCipher();

      Console.Write("Введите текст для шифровки: ");
      string encryptWorld = Console.ReadLine()!.ToUpper();
      Console.Write("Введите порол: ");
      string passwordE = Console.ReadLine()!.ToUpper();

      await vigenere.EncryptAsync(encryptWorld, passwordE);
      Console.WriteLine($"ваш шифрованный текст: \n{Data.ResultEncrypt}");

      Console.Write("порол: ");
      string passwordD = Console.ReadLine()!.ToUpper();
      await vigenere.DecryptAsync(Data.ResultEncrypt, passwordD);
      Console.WriteLine($"ваш дешифрованный текст: \n{Data.ResultDecrypt}");
      Console.ReadLine();
    }
  }
}
