string[] arr1 = new string[5] { "Пар", "но", "99", "Привет!", "нет" };
string[] arr2 = new string[arr1.Length];

Console.WriteLine(" ");
Console.WriteLine("Элементы первого массива:");
PrintArr(arr1);
Console.WriteLine(" ");
SecondArr(arr1, arr2);
Console.WriteLine("Элементы второго массива:");
PrintArr(arr2);

void SecondArr(string[] arrFirst, string[] arrSecond)
{
    int count = 0;
    for (int i = 0; i < arrFirst.Length; i++)
    {
        if (arrFirst[i].Length <= 3)
        {
            arrSecond[count] = arrFirst[i];
            count++;
        }
    }
}

void PrintArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}