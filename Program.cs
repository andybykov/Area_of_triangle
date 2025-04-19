/* Упражнение 5 */

/* 
Требуется создать программу, которая подсчитывает площадь 
равностороннего треугольника, периметр которого известен
*/
using System; // подключение пространства имен System

class AreaTriangle
{
    static void Main(string[] args)
    {

        int a, b, c;                                          // объявляем переменные
        Console.WriteLine("Enter side a:");                    //приглашение к вводу
        a = Int32.Parse(Console.ReadLine());                  //инициализируем а

        Console.WriteLine("Enter side b:");                    //приглашение к вводу
        b = Int32.Parse(Console.ReadLine());                  //инициализируем b

        Console.WriteLine("Enter side c:");                    //приглашение к вводу
        c = Int32.Parse(Console.ReadLine());                  //инициализируем c


        double perimeter = (double) (a + b + c);                      // рассчитываем периметир
        double p = perimeter / 2;                          // рассчитываем полупериметр - явно преобразуем в double

        //Console.WriteLine("Semi-perimerter = {0:F3}", p); // форматируем до 3 знаков после запятой
        double area = Math.Sqrt(p * ((p - a) * (p - b) * (p - c)));
        Console.WriteLine("Area of triangle = {0:F3}", area); // форматируем до 3 знаков после запятой


    }
}




