

int num = 121;
bool IsPalindrome(int x)
{
    int reminder;
    int revNumber = 0;
    int temp = x;

    while (x > 0)
    {
        reminder = x % 10;
        x = x / 10;
        revNumber = (revNumber * 10) + reminder;

    }
    if (revNumber == temp)
    {
        return true;
    }
    else
    {

        return false;
    }
}

Console.WriteLine(IsPalindrome(num));