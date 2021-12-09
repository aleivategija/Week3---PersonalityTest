using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma lemmikv2rv:");

            string userColor = Console.ReadLine();

            if (userColor == "punane")
            {
                Console.WriteLine("Oled romantiline.");
            }
            else if (userColor == "sinine")
            {
                Console.WriteLine("Oled t66kas.");
            }
            else if (userColor == "roheline")
            {
                Console.WriteLine("Oled looduse s6ber");
            }
            else
            {
                Console.WriteLine($"Oled {userColor} ykssarvik");
            }

            Console.WriteLine("Kena p2eva!");
        }
    }
}
