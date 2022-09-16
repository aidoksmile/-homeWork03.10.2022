// Написать программу копирования массива

int Counter(string str, char symbol)
{
    int count = 0;
    for(int i=0; i<str.Length; i++)
        if(str[i] == symbol)
            count++;
    return count;
}

string [] CopyStr(string str, char symbol)
{
    string[] coordinates = new string[Counter(str,symbol)+1];
    int amount=0;
    for(int i=0;i<str.Length;i++)
    {
        if (str[i] == symbol)
        {
            amount++;
            continue;
        }

        coordinates[amount] = coordinates[amount] + str[i];
    }
    return coordinates;
}

void PrintArray(string[] array)
{
    for(int i=0;i<array.Length;i++) 
    Console.Write($"{array[i]} ");
}

Console.Write("Введите элементы массива через пробел: ");
string array = Console.ReadLine();
string[] copyArray = CopyStr(array, ' ');
Console.WriteLine("Копия массива создана и имеет название copyArray: ");
PrintArray(copyArray);