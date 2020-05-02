using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
    class Program
    {
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
                if (gunre == "комедия")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Горячие головы 1 и 2 часть");
                    Console.WriteLine("Эйс Вентура");
                    Console.WriteLine("Одноклассники");
                    
                }
                else if (gunre == "ужасы")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Зеркала 2008 года");
                    Console.WriteLine("Астрал все части");
                    Console.WriteLine("Паранормальное Явление");
                }
                else if (gunre == "сериал")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Видеть");
                    Console.WriteLine("Игра престолов");
                    Console.WriteLine("Ведьмак");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("по брастки выбирай из предложенного");
                    Console.ReadKey();
                    continue;
                }

                
                Console.WriteLine("Что то выбрал?");
                string otvet = Console.ReadLine();

                if (otvet == "нет")
                {
                    Console.WriteLine("Хочешь ещё раз глянуть список фильмов?");
                    string otvet2 = Console.ReadLine();

                    if (otvet2 == "да")
                    {
                        Console.WriteLine("Комедии:");
                        Console.WriteLine("Горячие головы 1 и 2 часть");
                        Console.WriteLine("Эйс Вентура");
                        Console.WriteLine("Одноклассники");
                        Console.WriteLine("Ужасы: ");
                        Console.WriteLine("Зеркала 2008 года");
                        Console.WriteLine("Астрал все части");
                        Console.WriteLine("Паранормальное Явление");
                        Console.WriteLine("Сериалы: ");
                        Console.WriteLine("Видеть");
                        Console.WriteLine("Игра престолов");
                        Console.WriteLine("Ведьмак");
                    }

                    else
                    {
                        Console.WriteLine("Ну тогда ищи сам в инете.");
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Хорошего просмотра!");
                }

                Console.ReadKey();

            }
        }
    }
}
