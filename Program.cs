// Итоговая проверочная работа. 

string[] CheckArrayElement(string[] arrayString)
{
    string[] checkedArray = new string[arrayString.Length];
    for (int i = 0; i < arrayString.Length; i++)
    {
        if (arrayString[i].Length <= 3) checkedArray[i] = arrayString[i];
    }
    return checkedArray.Where(x => x != null).ToArray();
}

void PrintStringArray(string[] array)
{
    Console.Write("[");
    if (array.Length != 0)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i != array.Length - 1) Console.Write($"{array[i]}, ");
            else Console.WriteLine($"{array[i]}]");
        }
    }
    else Console.Write("]");
}

try
{
    Console.Write("Введите массив строк через ', ':\t");
    string[] stringArray = Console.ReadLine().Split(", ").ToArray();
    Console.Write("Результат:\t");
    PrintStringArray(CheckArrayElement(stringArray));
}
catch 
{
    Console.WriteLine("Ошибка ввода!");
}