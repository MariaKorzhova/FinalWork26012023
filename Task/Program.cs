string[] array1 = new string[5];
Console.WriteLine("Введите первую строку");
array1[0] = Convert.ToString(Console.ReadLine());
Console.WriteLine("Введите вторую строку");
array1[1] = Convert.ToString(Console.ReadLine());
Console.WriteLine("Введите третью строку");
array1[2] = Convert.ToString(Console.ReadLine());
Console.WriteLine("Введите четвёртую строку");
array1[3] = Convert.ToString(Console.ReadLine());
Console.WriteLine("Введите пятую строку");
array1[4] = Convert.ToString(Console.ReadLine());
System.Console.Write(string.Join(" ", array1));
System.Console.WriteLine();
string[] array2 = FillArrayAndPrint(array1);

string[] FillArrayAndPrint(string[] Array1)
{
    string[] Array = new string[5];
    int n = 0;
    for (int i = 0; i < Array1.Length; i++)
    {
        if (Array1[i].Length <= 3)
        {
            Array[n] = Array1[i];
            n = n + 1;
        }
    }
    if (n == 0)
    {
        Console.WriteLine("Длина каждого элемента первоначального массива составляет больше трёх символов");
    }
    else
    {
        System.Console.Write(string.Join(" ", Array));
    }
    return Array;
}

