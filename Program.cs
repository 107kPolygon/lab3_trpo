using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_trpo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите значение A и после B:");

            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Выберите действие, введя номер пункта: ");
            Console.WriteLine("1.+\n2.-\n3.*\n4./\n");

            int q = int.Parse(Console.ReadLine());

            switch (q)
            {
                case 1:
                    sum(a, b);
                    break;
                case 2:
                    min(a, b);
                    break;
                case 3:
                    umn(a, b);
                    break;
                case 4:
                    del(a, b);
                    break;
            }
        }

        static void del(float a, float b)
        {
            Console.Clear();
            Console.WriteLine($"{a / b}");
            Console.ReadKey();
        }
    
    }
}
