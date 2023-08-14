

int[] arr = new int[] { 1, 1, 2, 3, 3, 4, 5 };
int[] nums = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };


int RemoveDuplicates2(int[] arr)
{
    int lengthWithoutDuplicates = 1;
    foreach (int n in nums)
    {
        if (nums[lengthWithoutDuplicates - 1] != n)
        {
            nums[lengthWithoutDuplicates++] = n;            
        }
    }
    return lengthWithoutDuplicates;
}

Console.WriteLine(RemoveDuplicates2(nums));