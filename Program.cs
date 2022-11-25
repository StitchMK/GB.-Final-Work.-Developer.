string[] CreateArray (int size)
{
    string[] newArray = new string[size];

    for(int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input an array element");
        string element = Convert.ToString(Console.ReadLine());
        newArray[i] = element;
    }

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    
        Console.Write(array[i] + " ");   
    Console.WriteLine();
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateArray(size);
ShowArray(myArray);

