string[] elementsArray = new string[] {"ace", "atom", "go", "back", "add", "bake", "up", "box", "ball", "alarm", "us", "bear", "fox", "do", "after", "cat", "ask", "alone", "bad", "bet", "alloy"};

void CheckElementsInArray(string[] array)
{
    string[] newArray = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        // PrintArray(MakeNewArray(newArray, array[i], i));
        Console.WriteLine(array[i]);
    }
}

// string[] MakeNewArray(string[] array, string element, int index)
// {
//     Array.Resize(ref array, array.Length + 1);
//     array[index] = element;
//     return array;
// }

void PrintArray(string[] array)
{
    Console.WriteLine("[" + $"{String.Join(", ", array)}" + "]");
}

PrintArray(elementsArray);
CheckElementsInArray(elementsArray);
