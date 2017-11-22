using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            // SixthTask();
            // SeventhTask();
            EighthTask();
        }

        private static void EighthTask()
        {
            Console.WriteLine("Введите объем 1 тела");
            int amountFirst = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите объем 2 тела");
            int amountSecond = int.Parse(Console.ReadLine());
        }

        private static void SeventhTask()
        {
            Console.WriteLine("Введите радиус круга");
            int R=int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону квадрата");
            int side = int.Parse(Console.ReadLine());
            double squareRound = Math.PI * Math.Pow(R, 2);
            double squareSq = Math.Pow(side, 2);
            if (squareRound > squareSq)
            {
                Console.WriteLine("Площадь круга больше площади квадрата");
            }
            else
            {
                Console.WriteLine("Площадь квадрата больше площади круга");
            }
            Console.ReadLine();
        }

        private static void SixthTask()
        {
            bool A = true;
            bool B = false;
            bool C = false;
            if (A || B)
            {
                Console.WriteLine("A||B=true");
            
            }
            else
            {
                Console.WriteLine("A||B=false");
         
            }
            if (A && B)
            {
                Console.WriteLine("A&&B=true");
              
            }
            else
            {
                Console.WriteLine("A&&B=false");
                
            }
            if (B||C)
            {
                Console.WriteLine("B||C=true");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("B||C=false");
                Console.ReadLine();
            }
        }
    }
}
