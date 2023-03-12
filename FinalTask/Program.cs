


Console.WriteLine("Введите количество строк: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Элементы с каким максимальным количеством символов вы хотите вывести?");
int m = int.Parse(Console.ReadLine()!);
string[] array = new string[n];

GetArray(array);
PrintArray(array);
Get3SymbolsEl(array);

// Метод создает массив на основе введенных пользователем данных.
void GetArray(string[] somearray)
{
    for (int i = 0; i < somearray.Length; i++)
    {
        Console.WriteLine($"Введите строку №{i}: ");
        array[i] = Console.ReadLine()!;
    }
}
// Метод выводит обозначенный массив в консоль.
void PrintArray(string[] somearray)
{
    Console.WriteLine("Вы ввели следующие строки: ");
    Console.Write("[");
    for (int i = 0; i < somearray.Length - 1; i++)
    {
        Console.Write($"{somearray[i]}, ");
    }
    Console.WriteLine($"{somearray[somearray.Length - 1]}]");
}
// Метод определяет количество символов в элементе массива и выводит те, чье количество символов не превышает m.
void Get3SymbolsEl(string[] somearray) 
{
    Console.WriteLine($"Следующие элементы имеют не больше {m} символов: ");
    Console.Write("[");
    for (int i = 0; i < somearray.Length; i++)
    {
        if (somearray[i].Length <= m)
        {
            Console.Write($"{somearray[i]}, ");
        } 
    }
    Console.Write("]");
}