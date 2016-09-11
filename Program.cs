using System;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToUpper();
            
            Console.WriteLine("Message?");
            var message = Console.ReadLine().Trim();
            
            while (true)
            {
                Console.WriteLine("Key?");
                var key = Console.ReadLine().Trim().ToUpper();
                
                var result = string.Empty;

                for (int i = 0; i < message.Length; i++)
                {
                    var c = message[i];
                    var k = key[i % key.Length];

                    var cindex = alphabet.IndexOf(c) + 1;
                    var kindex = alphabet.IndexOf(k) + 1;

                    var r = (kindex + cindex - 1) % alphabet.Length;

                    result += alphabet[r];
                }

                Console.WriteLine($"---- {result}");
            }
        }
    }
}
