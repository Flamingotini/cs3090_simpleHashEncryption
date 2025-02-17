using System.Text;

namespace SimpleHashEncryptionTool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? phrase;
            string? password;
            ConsoleKey key;
            bool active = true;

            Console.WriteLine("Welcome to...Secret Message (Dis)Combobulator!");            

            while (active) 
            {
                int? menuChoice;
                do
                {
                    Console.WriteLine("\nMenu:");
                    Console.WriteLine("1) Encrypt new message");
                    Console.WriteLine("2) Decrypt old message");
                    Console.WriteLine();
                    key = Console.ReadKey().Key;
                }
                while (!IsValidKey(key, out menuChoice));

                if (menuChoice == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("\nEnter phrase to encrypt:");
                    phrase = Console.ReadLine();
                    Console.WriteLine("\nEnter password:");
                    password = Console.ReadLine();
                    Console.WriteLine("\nEncoded message: " + Encrypt(phrase, password));
                }
                else if (menuChoice == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("\nEnter message to decrypt:");
                    phrase = Console.ReadLine();
                    Console.WriteLine("\nEnter password:");
                    password = Console.ReadLine();
                    Console.WriteLine("\nDecoded message: " + Decrypt(phrase, password));
                }

                Console.WriteLine("\nMain Menu? Press 'Y' or EXIT");
                key = Console.ReadKey().Key;
                if (key != ConsoleKey.Y) active = false;
                Console.WriteLine();
            }

            Console.WriteLine("\nGoodbye!");
            Console.ReadKey();
        }

        private static bool IsValidKey(ConsoleKey key, out int? option)
        {
            switch (key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    option = 1; return true;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    option = 2; return true;
                default:
                    option = null; return false;
            }
        }

        private static string Encrypt(string phrase, string password)
        {
            StringBuilder sb = new StringBuilder();
            char[] passChars = password.ToCharArray();
            char[] phraseChars = phrase.ToCharArray();

            for (int i = 0; i < phrase.Length; i++)
            {
                int pwnum = (int)passChars[i % passChars.Length];
                int phnum = (int)phraseChars[i];                
                int sum = phnum + pwnum;                
                sb.Append(sum);
                if (i < phrase.Length - 1) 
                {
                    sb.Append('.');
                }
            }
            return sb.ToString();
        }

        private static string Decrypt(string phrase, string password)
        {
            StringBuilder sb = new StringBuilder();
            char[] passChars = password.ToCharArray();
            string[] phraseChunks = phrase.Split(".");

            for (int i = 0; i < phraseChunks.Length; i++)
            {
                int pwnum = (int)passChars[i % passChars.Length];                
                int chunknum = int.Parse(phraseChunks[i]);                
                int val = chunknum - pwnum;               
                sb.Append((char)val);
            }

            return sb.ToString();
        }
    }
}
