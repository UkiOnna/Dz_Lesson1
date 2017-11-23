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
            FirstTask();
            Second_Task();
            TenthTask();
           SixthTask();
            SeventhTask();
            ThirdTask();
            FourthTask();
            FifthTask();
             EighthTask();
            NinethTask();
        }
        private static void TenthTask()
        {
            for (int i = 20; i < 36; i++)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("Введите число b  (b>10)");
            int b = int.Parse(Console.ReadLine());
            for (int i = 10; i < b + 1; i++)
            {
                Console.WriteLine(Math.Pow(i, 2));
            }
            Console.WriteLine("Введите число a  (a<50)");
            int a = int.Parse(Console.ReadLine());
            for (int i = a; i < 51; i++)
            {
                Console.WriteLine(Math.Pow(i, 3));
            }
            Console.WriteLine("Введите число b  (b>a)");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число a  (b>a)");
            a = int.Parse(Console.ReadLine());
            for (int i = a; i < b + 1; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        private static void NinethTask()
        {
            Console.WriteLine("Введите сопротивление 1 участка");
            int resistanceFirst = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сопротивление 2 участка");
            int resistanceSecond = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите напряжение 1 участка");
            int voltageFirst = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите напряжение 2 участка");
            int voltageSecond = int.Parse(Console.ReadLine());
            double voltFirst = voltageFirst / resistanceFirst;
            double voltSecond = voltageSecond / resistanceSecond;
            if (voltFirst > voltSecond)
            {
                Console.WriteLine("По 2 участку протекает меньший ток ");
            }
            else
            {
                Console.WriteLine("По 1 участку протекает меньший ток ");
            }
            Console.ReadLine();
        }

        private static void FifthTask()
        {
            Console.WriteLine("Введите двузначноечисло");
            string numberAsString = Console.ReadLine();
            int numberAsInt = int.Parse(numberAsString);
            int divider = 10;
            int decade = numberAsInt / divider;
            int units = numberAsInt % divider;
            int summa = decade + units;
            int composition = decade * units;
            Console.Write("Десятков = ");
            Console.WriteLine(decade);
            Console.Write("Едениц = ");
            Console.WriteLine(units);
            Console.Write("Сумма = ");
            Console.WriteLine(summa);
            Console.Write("Произведение = ");
            Console.WriteLine(composition);
            Console.ReadLine();
        }

        private static void FourthTask()
        {
            int pastDays = 234;
            int week = 7;
            int fulWeek = pastDays / week;
            Console.Write("Полных недель - ");
            Console.WriteLine(fulWeek);
            Console.ReadLine();
        }

        private static void ThirdTask()
        {
            Console.WriteLine("Введите расстояние в сантиметрах");
            string distanceAsString = Console.ReadLine();
            int distanceAsIntInSantimetrs = int.Parse(distanceAsString);
            int divider = 100;
            int distanceInMeters = distanceAsIntInSantimetrs / divider;
            Console.Write("Расстояние в сантиметрах - ");
            Console.WriteLine(distanceInMeters);
            Console.ReadLine();
        }
        private static void EighthTask()
        {
            Console.WriteLine("Введите объем 1 тела");
            int amountFirst = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите объем 2 тела");
            int amountSecond = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вес 1 тела");
            int weightFirst = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вес 2 тела");
            int weightSecond = int.Parse(Console.ReadLine());
            double densityFirst = weightFirst / amountFirst;
            double densitySecond = weightSecond / amountSecond;
            if (densityFirst > densitySecond)
            {
                Console.WriteLine("1 тело имеет большую плотность");
            }
            else
            {
                Console.WriteLine("2 тело имеет большую плотность");
            }
            Console.ReadLine();
        }

        private static void SeventhTask()
        {
            Console.WriteLine("Введите радиус круга");
            int R = int.Parse(Console.ReadLine());
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
            if (B || C)
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


        private static void Second_Task()
        {
            Console.WriteLine("5");
            Console.WriteLine("10");
            Console.WriteLine("21");
            Console.ReadLine();
        }

        private static void FirstTask()
        {
            Console.WriteLine("21  12  12");
            Console.ReadLine();
        }

    }
}
