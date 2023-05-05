int[] arr = new int[] { 3, 2, 3 };

int[] TwoSum(int[] nums, int target)
{
    for (int i = 0; i < nums.Length - 1; i++)
    {
        for (int j = i + 1; j <= nums.Length - 1; j++)
        {

            int temp = nums[i] + nums[j];
            if (temp == target)
            {
                return new int[] { i, j };
            }
        }
    }
    return new int[] { -1 };
}


foreach (var item in TwoSum(arr, 6))
{
    Console.WriteLine(item);
}