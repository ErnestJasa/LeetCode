
string LongestCommonPrefix(string[] strs)
{
    string prefix = "";
    int i = 0;
    string shortest = strs.OrderBy(x => x.Length).First(); // gets shortest string

    foreach (char c in shortest) // iterates through each charater of the shortest string
    {
        if (strs.Any(s=> s[i] !=  c)) // checks if any strings in the array dont match the current character of iteration and exists the loop
        {
            break;
        }
        prefix = prefix + c; // appends the character if it matches and continues
        i++;
    }

    return prefix;

}


string[] arr = { "bcgf", "bc", "bcgre" };



Console.WriteLine(LongestCommonPrefix(arr));