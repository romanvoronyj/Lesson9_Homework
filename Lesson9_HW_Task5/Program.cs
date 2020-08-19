using System;

namespace Lesson9_HW_Task5
{
    class Point
    {
        public int one;
        public int two;
        public string pole;

        public int One//чому ми перевіряємо це значення, якщо в нас є тільки модифікатор get ?
        {
            get
            {
                if (one == 0)
                {
                    Console.WriteLine("Не введено даних!");
                    return 0;
                }
                else
                {
                    return one;
                }
            }
        }
        public double Two//чому ми перевіряємо це значення, якщо в нас є тільки модифікатор get ?
        {
            get
            {
                if (two == 0)
                {
                    Console.WriteLine("Не введено даних!");
                    return 0;
                }
                else
                {
                    return two;
                }
            }
        }
        public string Pole//чому ми перевіряємо це значення, якщо в нас є тільки модифікатор get ?
        {
            get
            {
                if (pole == null)
                {
                    Console.WriteLine("Не введено даних!");
                    return null;
                }
                else
                {
                    return pole;
                }
            }
        }



    }
    class Figure    
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

        }
    }
}
