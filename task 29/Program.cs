//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateArray(int num)
{
    int[] array = new int[num];
    return array;
}

void FillArray(int[] randomArray)
{
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(0, 10001);
    }
}

void PrintArray(int[] array)
{
    foreach (int elem in array)
    {
        Console.Write($"{elem} ");
    }
}

while (true)
{
    Console.Write("Введите размер массива. "); // в задаче 8, но это не интересно, вы говорили избавляться от волшебных чисел)

    bool numBool = false;
    int num = 0;
    int count1 = 0;
    int count2 = 0;

    while (!numBool)
    {
        Console.WriteLine("Число должно быть целым.");
        numBool = int.TryParse(Console.ReadLine()!, out num);
    }
    int[] array = CreateArray(num);
    FillArray(array);
    Console.WriteLine($"Наш массив из {num} случайных чисел:");
    PrintArray(array);

    foreach (int elem in array)
    {
        if (elem % 2 == 0)
        {
            count1++;
        }
        else count2++;
    }
    Console.WriteLine();
    Console.WriteLine($"В массиве {count1} четных и {count2} нечетных чисел");

    Console.WriteLine();
    Console.WriteLine("Enter чтобы продолжить / q чтобы выйти");
    ConsoleKeyInfo quite = Console.ReadKey();
    Console.WriteLine();
    if (quite.KeyChar == 'q' || quite.KeyChar == 'й') break;
}