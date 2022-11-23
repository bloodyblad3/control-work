void ArrayWithThreeSymbols(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] array = new string[6] { "321", "23", "1234", "hello world", "ser", "2" };
string[] modifiedArray = new string[array.Length];

ArrayWithThreeSymbols(array, modifiedArray);
PrintArray(modifiedArray);
