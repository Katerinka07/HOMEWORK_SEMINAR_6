/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
double InputNum(string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine()!);
}
double[] IntersPoint(double num1, double num2, double num3, double num4)
{
    double resX = (num3 - num1) / (num2 - num4);
    double resY = num4 * resX + num3;
    double[] array = new double[2];
    array[0] = resX;
    array[1] = resY;
    return array;
}
void PrintArray(double[] array)
{
    Console.Write("(");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + ")");
}
double b1 = InputNum("Введите значение b1: ");
double k1 = InputNum("Введите значение k1: ");
double b2 = InputNum("Введите значение b2: ");
double k2 = InputNum("Введите значение k2: ");
double[] result = IntersPoint(b1, k1, b2, k2);
PrintArray(result);
Console.WriteLine();
if (result[0] != result[1]) Console.WriteLine("Прямые не пересекаются");
