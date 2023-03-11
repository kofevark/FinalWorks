// Программа, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. 

Console.Clear();

// Работа с пользователем.
// ---------------------
Console.Write("Сформируем произвольный массив и найдем в нем элементы длиной до 3-х символов.\nВведите желаемый размер массива: ");
int size = int.Parse(Console.ReadLine()!);

// Основной процесс программы.
// ---------------------
string[] array = FillArray(size);
Console.Write($"Исходный массив - > ");
PrintArray(array);
string[] newArray = ArrayConversion(array);
Console.Write($" Искомый массив - > ");
PrintArray(newArray);

// Методы.
// ---------------------
// Метод заполнения массива.
string[] FillArray(int someSize)
{
    string[] someArray = new string[size];
    for (int i = 0; i < someSize; i++)
    {
        Console.Write($"Введите значение {i + 1}-го элемента массива: ");
        someArray[i] = Console.ReadLine()!;
    }
    return someArray;
}

// Метод печати массива.
void PrintArray(string[] someArray)
{
    if (someArray.Length > 0)
    {
        Console.Write("[");
        for (int i = 0; i < someArray.Length - 1; i++)
        {
            Console.Write($"'{someArray[i]}', ");
        }
        Console.WriteLine($"'{someArray[someArray.Length - 1]}']");
    }
    else Console.WriteLine("нет подходящих элементов.");
}

// Метод преобразования исходного массива в массив с 3-х символьными элементами.
string[] ArrayConversion(string[] someArray)
{
    string[] someConvertedArray = new string[size];
    int j = 0;
    for (int i = 0; i < someArray.Length; i++)
    {
        if (someArray[i].Length <= 3)
        {
            someConvertedArray[j] = someArray[i];
            j++;
        }
    }
    Array.Resize(ref someConvertedArray, j); // Усекаем полученный массив до необходимого размера.
    return someConvertedArray;
}