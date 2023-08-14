string haystack = "hkjasdfkiykiuytasdfkiyki";

string needle = "kiyki";

int ReturnIndex(string haystack, string needle)
{

    if (haystack.Contains(needle))
    {
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i..(needle.Length + i)] == needle)
            {
                return i;
            }
        }
        return 0;
    }
    else
    {
        return -1;
    }
}
Console.WriteLine(ReturnIndex(haystack, needle));

Console.WriteLine(haystack.IndexOf(needle));