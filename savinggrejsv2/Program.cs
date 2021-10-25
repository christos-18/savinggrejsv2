using System;
using System.IO;
using System.Text.Json;

namespace savinggrejsv2
{
    class Program
    {
        static void Main(string[] args)
        {
            string svar;

            Hero player = new Hero();

            System.Console.WriteLine("Vad vill din hero heta?");

            svar = Console.ReadLine();

            player.name = svar;

            System.Console.WriteLine("Hur mycket skada vill du göra?");

            svar = Console.ReadLine();

            player.damage = int.Parse(svar);

            System.Console.WriteLine("Hur mycket hp vill du ha?");

            svar = Console.ReadLine();

            player.hp = int.Parse(svar);



            string json;

            json = JsonSerializer.Serialize<Hero>(player);

            File.WriteAllText(@"text.json", json);




        }
    }
}
