string[] elementsArray = new string[] {"ace", "atom", "go", "back", "add", "bake", "up", "box", "ball", "alarm", "us", "bear", "fox", "do", "after", "cat", "ask", "alone", "bad", "bet", "alloy"};

void CheckElementsInArray(string[] array)
{
    string[] newArray = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        MakeNewArray(newArray, array[i]);
        // Console.WriteLine(array[i]);
    }
    PrintArray(newArray);
    Console.WriteLine(newArray.Length);
}

string[] MakeNewArray(string[] array, string element)
{
    Array.Resize(ref array, array.Length + 1);
    array[array.Length-1] = element;
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[" + $"{String.Join(", ", array)}" + "]");
}

PrintArray(elementsArray);
Console.WriteLine();
CheckElementsInArray(elementsArray);
Console.WriteLine();
