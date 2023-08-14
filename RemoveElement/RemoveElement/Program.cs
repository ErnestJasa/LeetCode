

int[] array = new[] { 1, 2, 3, 3, 3, 4 };

int Remove(int[] arr, int valueToRemove)
{
    int current = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != valueToRemove)
        {
            arr[current] = arr[i];
            current++;
        }
    }
   
   
    return current;
}

Console.WriteLine(Remove(array, 3));