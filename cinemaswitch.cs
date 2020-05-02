using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cinemaswitch
{

    class Program
    {
        public static void Films()
        {
            var text = File.ReadAllLines("1.txt", Encoding.UTF8);
            string[,] films = new string[text.Length, 3];
            int increment = 0;
            foreach (var stroka in text)
            {
                var split = stroka.Split(new[] { ',' });
                films[increment, 0] = split[0];
                films[increment, 1] = split[1];
                films[increment, 2] = split[2];

                increment++;
            }

            for (var i = 0; i < films.GetLength(0); i++)
            {
                if (films[i, 2] == "Гайдар")
                {
                    for (int j = 0; j < films.GetLength(1); j++)
                    {
                        Console.Write($"{films[i, j]} ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}


static void Main(string[] args)
{
    while (true)
    {
        Console.Clear();

        Console.WriteLine("Как зовут?");
        var name = Console.ReadLine();

        Console.WriteLine("Здарова, " + name + "! Ща помогу подобрать фильм на вечер");
        Console.WriteLine("Что хочешь посмотреть? Выбери из предложенного и напиши: Комедия, ужасы или сериал?");

        var gunre = Console.ReadLine();
        switch (gunre)
        {
            case "комедия":
                var a = new StreamReader("C:\\1.txt");
                Console.WriteLine(a.ReadToEnd());
                break;
            case "ужасы":
                var b = new StreamReader("C:\\1.txt");
                Console.WriteLine(b.ReadToEnd());
                break;
            case "сериал":
                var c = new StreamReader("C:\\1.txt");
                Console.WriteLine(c.ReadToEnd());
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("по брастки выбирай из предложенного");
                Console.ReadKey();
                continue;

        }
        Console.WriteLine("Что то выбрал?");
        string otvet = Console.ReadLine();
        switch (otvet)
        {
            case "нет":
                Console.WriteLine("Хочешь ещё раз глянуть список фильмов?");
                string otvet2 = Console.ReadLine();
                switch (otvet2)
                {
                    case "да":
                        Films();

                        break;
                    default:
                        Console.WriteLine("Ну тогда ищи сам в инете.");
                        break;
                }
                break;

            default:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Хорошего просмотра!");
                break;
        }

        Console.ReadKey();


    }
}
    }
}





