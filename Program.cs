using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cont;

            do
            {

                double fn;
                double sn;
                string o;
                double answ;

                Console.Clear();
                Console.WriteLine("Первое число: ");
                fn = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Действие %, *, /, +, - : ");
                o = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Второе число: ");
                sn = Convert.ToDouble(Console.ReadLine());

                if (o == "+")
                {

                    answ = fn + sn;
                    Console.WriteLine("Результат: " + answ);

                }

                if (o == "-")
                {

                    answ = fn - sn;
                    Console.WriteLine("Результат: " + answ);

                }

                if (o == "*")
                {

                    answ = fn * sn;
                    Console.WriteLine("Результат: " + answ);

                }

                if (o == "/")
                {

                    answ = fn / sn;
                    Console.WriteLine("Результат: " + answ);

                }

                if (o == "%")
                {

                    answ = fn % sn;
                    Console.WriteLine("Результат: " + answ);

                }

                Console.WriteLine("Совершить еще одну операцию? (да/нет)");
                cont = Convert.ToString(Console.ReadLine());

            } while (cont == "да");

        }
    }
}
