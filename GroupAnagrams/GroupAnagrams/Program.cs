// See https://aka.ms/new-console-template for more information
using System.Text;

string[] words = ["eat", "tea", "tan", "ate", "nat","bat"];

IList<IList<string>> Anagrams(string[] strings)
{
    if (strings.Length == 0)
    {
        return [];
    }
    Dictionary<string, List<string>> anagrams = new();

    foreach (string word in strings)
    {
        int[] count = new int[26];
        foreach (char c in word)
        {
            count[c - 'a']++;

        }

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 26; i++)
        {
            sb.Append("#");
            sb.Append(count[i]);
        }
        string key = sb.ToString();

        if (!anagrams.ContainsKey(key))
        {
            anagrams[key] = new List<string>();
        }
        anagrams[key].Add(word);
    }

    return new List<IList<string>>(anagrams.Values);

}


// IList<IList<string>> GroupAnagrams(string[] strs)
//{
//    if (strs == null || strs.Length == 0)
//    {
//        return new List<IList<string>>();
//    }
//    Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
//    foreach (string s in strs)
//    {
//        char[] ch = s.ToCharArray();
//        Array.Sort(ch);
//        string keyStr = new string(ch);

//        if (!map.ContainsKey(keyStr))
//        {
//            map[keyStr] = new List<string>();
//        }
//        map[keyStr].Add(s);
//    }
//    return new List<IList<string>>(map.Values);
//}

foreach (var word in Anagrams(words)[0])
{
    Console.WriteLine(word);
}

