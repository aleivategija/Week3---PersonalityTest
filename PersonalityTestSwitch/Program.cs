using System;

namespace PersonalityTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma lemmikv2rv:");

            string userColor = Console.ReadLine().ToLower();

            switch(userColor)
            {
                case "punane":
                    Console.WriteLine("Oled romantiline");
                    break;
                case "sinine":
                    Console.WriteLine("Oled t66kas");
                    break;
                case "roheline":
                    Console.WriteLine("Oled looduse s6ber");
                    break;
                default:
                    Console.WriteLine($"Oled {userColor} ykssarvik");
                    break;
            }

            Console.WriteLine("Kena p2eva!");
        }
    }
}
