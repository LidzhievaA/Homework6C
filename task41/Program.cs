// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел, которое будет вами введено: ");
int numCount = Convert.ToInt32(Console.ReadLine());

int[] GetNumber(int count)
{
    int[] numArray = new int[count];
    for (int i = 0; i < numArray.Length; i++)
    {
        Console.WriteLine($"Введите число {i}: ");
        numArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return numArray;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int PositiveNumberCount(int[] getNum)
{
    int count = 0;
    for (int i = 0; i < getNum.Length; i++)
    {
        if (getNum[i] > 0) count++;
    }
    return count;
}

if (numCount <= 0) Console.WriteLine("Введено некорректное число");
else
{
    int[] number = GetNumber(numCount);
    PrintArray(number);
    int positiveNumberCount = PositiveNumberCount(number);
    Console.WriteLine($" -> {positiveNumberCount}");
}