

int[] arr = new[] { 1,2, 3, 4 };

int[] PlusOne(int[] arr)
{
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        if (i == 0 && arr[0] == 9)
        {
            int[] newArray = new int[arr.Length+1];
            newArray[0] = 1;
            
            return newArray;
        }
        if (arr[i] != 9)
        {
            arr[i] += 1;
            break;
        }
        else if (arr[i] == 9)
        {
            arr[i] = 0;
        }
        else
        {
            arr[i] += 1;
            break;
        }
    }

    return arr;
}

Console.WriteLine(PlusOne(arr));