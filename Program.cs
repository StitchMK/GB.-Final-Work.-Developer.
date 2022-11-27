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

/*
void ShowArray(string[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");   
    }
    

    Console.Write($"{array[array.Length - 1]}");   
    

    Console.Write("]");
    Console.WriteLine();
}
*/

void NoMoreThenThree(string[] array)
{   
    Console.Write("[");
    for(int i = 0; i < array.Length - 1; i++)
    {   
        string n = array[i];
        int l = n.Length;
        
        if(l <= 3)
        {
            Console.Write($"{n}, ");
        }
    }

        
    if(array[array.Length - 1].Length <= 3)
    {
        Console.Write($"{array[array.Length - 1]}");
    }
    

    Console.Write("]");
    Console.WriteLine();
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateArray(size);
Console.WriteLine("This is your array: ");
ShowArray(myArray);
Console.WriteLine("This is an array of elements whose string length is no longer than 3: ");
NoMoreThenThree(myArray);



