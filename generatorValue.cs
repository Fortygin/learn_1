using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            
            int value1 = rnd.Next(10);
            int value2 = rnd.Next(10);
            int value3 = rnd.Next(10);

            //Console.WriteLine(value1); 
            //Console.WriteLine(value2);
            //Console.WriteLine(value3);

            var sum = value1 + value2 + value3;
            var sum2 = value1 * value2 * value3;

            Console.WriteLine(sum + " - сумма трех чисел");
            Console.WriteLine(sum2 + " - произведение трех чисел");

            Console.ReadLine();
            int truCount = 1; //количество попыток угадывания
            int uservalue1; //первое число которое вводит пользователь
            int uservalue2;// второе число которое вводит пользователь
            int uservalue3;//третье число которое вводит пользователь

            
                Console.Clear();
                Console.WriteLine("Введите загаданные числа в диапозоне от 0 до 10");
                uservalue1 = Convert.ToInt32(Console.ReadLine());
                uservalue2 = Convert.ToInt32(Console.ReadLine());
                uservalue3 = Convert.ToInt32(Console.ReadLine());

                while (uservalue1 != value1)
                {
                    truCount++;
                    if (truCount == 5)
                        Console.WriteLine("Game Over");
                    break;
                }


              Console.ReadKey();
            


        }
    }
}
