

Console.WriteLine("Введите длину массива ");
int length;
length = Convert.ToInt32(Console.ReadLine());
string[] stringArray = CreateStringArray(length);
Console.WriteLine();
Console.WriteLine("Полученный массив строчных значений");
PrintArray(stringArray);
string[] sortArray = SortArrayUp(stringArray);
string[] redactArray = RedactStringArray(stringArray);
Console.WriteLine("Массив из элементов, в которых менее трёх символов");
PrintArray(redactArray);


string[] SortArrayUp(string[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = 0; j < arr.Length - 1; j++)
        {
            if(arr[j].Length > arr[j + 1].Length)
            {
                string temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
    return arr;
}

string[] RedactStringArray(string[] arr)
{
    int count = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length < 4)
        {
            count++;
        }       
    }
    string[] redactArray = new string[count];
    
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length < 4)
        {
            redactArray[i] = arr[i];
        }
    }
    return redactArray;
}

string[] CreateStringArray(int size)
{
    string[] array = new string[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите элемент массива №{i + 1}");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array) 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}