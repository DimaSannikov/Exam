string[] elementsArray = new string[] {"ace", "atom", "go", "back", "add", "bake", "up", "box", "ball", "alarm", "us", "bear", "fox", "do", "after", "cat", "ask", "alone", "bad", "bet", "alloy"};

void CreateNewArray(string[] array)
{
    string[] newArray = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        // ChangeArrayLength(newArray, array[i]);
        Array.Resize(ref newArray, newArray.Length + 1);
        newArray[newArray.Length-1] = array[i];
        // PrintArray(newArray);
        // Console.WriteLine(newArray.Length);
        // Console.WriteLine(array[i]);
    }
    PrintArray(newArray);
    // Console.WriteLine(newArray.Length);
}

// void ChangeArrayLength(string[] array, string element)
// {
//     Array.Resize(ref array, array.Length + 1);
//     array[array.Length-1] = element;
//     // return array;
// }

void PrintArray(string[] array)
{
    Console.Write("[" + $"{String.Join(", ", array)}" + "]");
}

// PrintArray(elementsArray);
Console.WriteLine();
CreateNewArray(elementsArray);
Console.WriteLine();
