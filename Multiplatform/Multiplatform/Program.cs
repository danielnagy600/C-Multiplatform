using System;
using System.Collections.Generic;
using System.Linq;

namespace Multiplatform
{
    class Program
    {
        static void Main(string[] args)
        {
            var squere = new Square(side: 4);
            Console.WriteLine($"Négyzet területe: {squere.Area()}");

            var circle = new Circle(radius: 5);
            Console.WriteLine($"Kör területe: {circle.Area()}");

            var triangle = new Triangle(triangleBase: 6, height: 4);
            Console.WriteLine($"Háromszög területe: {triangle.Area()}");

            var areaSum = squere.Area();

            areaSum += areaSum + triangle.Area();
            areaSum += areaSum + triangle.Area();

            var planes = new List<IPlane>();

            //var sum = 0;

            planes.Add(squere);
            planes.Add(circle);
            planes.Add(triangle);

            //I.MEGOLDÁS ciklussal
            //foreach (var plane in planes)
            //{
            //    sum += plane.Area();
            //}

            //II.MEGOLDÁS lambda kifejezéssel
            var sum = planes.Sum(x => x.Area());

            Console.WriteLine($"A területek összege: {sum}");

            //Var használata ellenőrzés nélkül
            Console.WriteLine("Írjon be egy egész számot.");
            var number = Convert.ToInt32(Console.ReadLine());
            var newNumber = Square(number);
            Console.WriteLine(newNumber);
            Console.ReadLine();
        }

        public static int Square(int number)
        {
            return number*number;
        }

       
    }
}
