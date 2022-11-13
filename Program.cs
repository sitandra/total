string[] GetNewStringArrayWithShortItems(string[] array, int maxLength = 3)
{
    int length = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength)
        {
            length++;
        }
    }
    string[] result = new string[length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength)
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

string OutputStringArray(string[] array)
{
    return array.Length == 0 ? "[]" : "[\"" + string.Join("\", \"", array) + "\"]";
}


string[] example1 = { "hello", "2", "world", ":-)" };
string[] example2 = { "1234", "1567", "-2", "computer science" };
string[] example3 = { "Russia", "Denmark", "Kazan" };

string[] result1 = GetNewStringArrayWithShortItems(example1);
string[] result2 = GetNewStringArrayWithShortItems(example2);
string[] result3 = GetNewStringArrayWithShortItems(example3);

Console.WriteLine(OutputStringArray(example1) + " -> " + OutputStringArray(result1));
Console.WriteLine(OutputStringArray(example2) + " -> " + OutputStringArray(result2));
Console.WriteLine(OutputStringArray(example3) + " -> " + OutputStringArray(result3));
