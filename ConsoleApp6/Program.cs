using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      
            Console.WriteLine("Write ur secret message!");
            string message = Console.ReadLine();
            char letter;
            char[] secretMessage = message.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];

            for(int i = 0; i < secretMessage.Length; i++)
            {
                letter = secretMessage[i];
                int index = Array.IndexOf(alphabet, letter);
                Console.WriteLine(index);
                letter = alphabet[index];
                encryptedMessage[i] = letter;
            }
            string enMess = String.Join("", secretMessage);
            Console.WriteLine(enMess);
        }
    }
}