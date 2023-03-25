string[] elementsArray = new string[] {"ace", "atom", "go", "back", "add", "bake", "up", "box", "ball", "alarm", "us", "bear", "fox", "do", "after", "cat", "ask", "alone", "bad", "bet", "alloy"};

string[] CreateNewArray(string[] array, int elementLength = 3)
{
    string[] newArray = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= elementLength)
        {
            Array.Resize(ref newArray, newArray.Length + 1);
            newArray[newArray.Length-1] = array[i];
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    Console.Write("[" + $"{String.Join(", ", array)}" + "]");
}

PrintArray(elementsArray);
Console.WriteLine();
PrintArray(CreateNewArray(elementsArray));
Console.WriteLine();
