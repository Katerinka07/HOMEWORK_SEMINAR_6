/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = InputNum($"Введите {i + 1}-й элемент: ");
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine();
}
int CountNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count ++;
    }
    return count;
}
int size = InputNum("Введите количество элементов: ");
int[] myArray = CreateArray(size);
FillArray(myArray);
PrintArray(myArray);
int res = CountNum(myArray);
Console.WriteLine($"Количество чисел больше 0: {res}");