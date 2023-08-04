
bool IsValid(string s)
{
    while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
    {
        s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
    }

    return s.Length == 0;
}





string test = "{[]}}";


if (test.Contains("[]"))
{
    test = test.Replace("[]", "");
    Console.WriteLine(test);
    Console.WriteLine(test.Contains("{}"));
}

Console.WriteLine(IsValid(test));
