/* Упражнение 5 */

/* 
Требуется создать программу, которая подсчитывает площадь 
равностороннего треугольника, периметр которого известен
*/
using System; // подключение пространства имен System

class AreaOfTriangle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter perimeter of triangle:");      //приглашение к вводу
        double perimeter = Double.Parse(Console.ReadLine());    //получаем периметр
        double side = perimeter / 3;                            //расситываем сторону
        double seimPer = perimeter / 2;                         // рассчитываем полупериметер
       // Console.WriteLine("Semi-perimerter = {0:F3}", seimPer); // форматируем до 3 знаков после запятой
        double area = Math.Sqrt(seimPer * Math.Pow(seimPer - side, 3));  //вычисляем площадь для равностороннего треугольника
        Console.WriteLine("Area of triangle = {0:F3}", area); // форматируем до 3 знаков после запятой 

    }
}




