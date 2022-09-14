string [] FillArray (string [] array)
{
    for (int  i = 0; i<array.Length; i++)
    {   Console.WriteLine ("Input array element value");
        array [i] = Console.ReadLine();
    }
    return array;
}

string [] MakeNewArray (string [] array)
{  int tempSize = 0;
    foreach (string element in array)
    {
        if (element.Length > 3) continue;
        else tempSize++;
    }
    string [] tempArray = new string [tempSize];
    int j = 0;
    foreach (string element in array)
    {
        if (element.Length > 3) continue;
        else tempArray[j] = element; j++;
    }
    return tempArray;
}


void PrintArray(string [] array)
{   Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write ($"{array[i]} ");        
    }
    
    Console.WriteLine("]");
}

Console.WriteLine("Input array size");
int size = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string [] array = new string [size];
array = FillArray(array);
Console.WriteLine();
Console.WriteLine("Your array:");
PrintArray (array);
Console.WriteLine();
string [] newArray = MakeNewArray(array);
Console.WriteLine();
Console.WriteLine("New array:");
PrintArray (newArray);

