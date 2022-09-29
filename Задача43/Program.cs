// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Введите b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2");
int k2 = Convert.ToInt32(Console.ReadLine());

double Function1 (int b1, int b2, int k1, int k2)
{
    double result = 0;
    double num = 0;
    double num2 = 0;

    num  = b1 - b2;
    num2 = k2 - k1;

    result = num/num2;
    return result;
}

double product =  Function1(b1, b2, k1, k2);

double Function2 (int b1, int k1, double pr)
{
    double y = 0;
    y = k1*pr + b1;
    return y;
}

Console.Write($" ({Function1(b1, b2, k1, k2)}, {Function2(b1, k1, product)} )");