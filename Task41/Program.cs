// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-7, 567, 89, 223-> 3

double[] ArrayCreator (int number)
{
    double[] array = new double[number];
    for (int count = 0; count < array.Length; count++)
    {
        Console.WriteLine($"Введите число номер {count+1}");
        array[count] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

int PositiveNumberCounter (double[] arr)
{
    int result = 0;
    for (int count = 0; count < arr.Length; count++)
    {
        if (arr[count] > 0) result++;

    }
    return result;
}


Console.WriteLine("Введите количество чисел");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Количество положительных чисел равно {PositiveNumberCounter(ArrayCreator(M))}");

