// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double [] Array()
{
    double [] arr = new double [2];
    System.Console.Write("Введите k: ");
    arr[0] = Convert.ToDouble(Console.ReadLine());
    System.Console.Write("Введите b: ");
    arr[1] = Convert.ToDouble(Console.ReadLine());
    return arr;
}

void Count(double [] arr1, double [] arr2)
{
    double x = (arr2[1] - arr1[1])/(arr1[0] - arr2[0]);
    double y = arr1[0]*x + arr1[1];
    System.Console.WriteLine($"Координата пересечения x: {x}");
    System.Console.WriteLine($"Координата пересечения y: {y}");
}

System.Console.WriteLine("Задаём первую прямую.");
double [] Array1 = Array();
System.Console.WriteLine("Задаём вторую прямую.");
double [] Array2 = Array();
Count(Array1, Array2);