using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_HW_Task2
{
    class Rectangle
    {
        public double side1;
        public double side2;
        private double area;
        private double perimeter;

        public double Area//чому ми перевіряємо це значення, якщо в нас є тільки модифікатор get ?
        {
            get
            {
                if(area == 0)
                {
                    Console.WriteLine("Не введено даних!");
                    return 0;
                }
                else
                {
                    return area;
                }
            }
        }
        public double Perimeter//чому ми перевіряємо це значення, якщо в нас є тільки модифікатор get ?
        {
            get
            {
                if (perimeter == 0)
                {
                    Console.WriteLine("Не введено даних!");
                    return 0;
                }
                else
                {
                    return perimeter;
                }
            }
        }
        public Rectangle (double side1, double side2)
        {
             this.side1 = side1;
             this.side2 = side2;
        }

        public double AreaCalculator()
        {
            double area = (double)side1 * side2;
            return area;
        }
        public double PerimeterCalculator()
        {
            double perimeter = (double)(side1 + side2)*2;
            return perimeter;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double x = 0, y = 0;


            Console.WriteLine("Введіть ширину прямокутника: ");
            x = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть довжину прямокутника: ");
            y = Double.Parse(Console.ReadLine());

            Rectangle myRectangle = new Rectangle(x, y);

            var a = myRectangle.AreaCalculator();
            Console.WriteLine("Площа прямокутника дорівнює {0} сантиметр(-ів)",a);
            var p=myRectangle.PerimeterCalculator();
            Console.WriteLine("Периметр прямокутника дорівнює {0} сантиметр(-ів)",p);

            Console.WriteLine(myRectangle.Area);
            Console.WriteLine(myRectangle.Perimeter);
            Console.ReadKey();



        }
    }
}
