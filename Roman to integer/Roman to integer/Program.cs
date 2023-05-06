

int RomanToInt(string s)
{
    Dictionary<char, int> _romanNumbers = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

    int result = 0;
    int next = 0;

    for (int i = 0; i < s.Length; i++)
    {
        int current = _romanNumbers[s[i]]; // get the current element we're on

        if (i+1 < s.Length) // check if there are any elements left
        {
            next = _romanNumbers[s[i+1]]; // if there are, get the next element in the sequence
        }
        else
        {
            next = 0;
        }

        if (current < next) // check if next element is bigger than the current one, because in roman numerics it goes from biggest to smallest,
                            // so if the next element is bigger than the current, we need to subract it
        {
            result += next - current;
            i++; // increment i because we just used both current and next elements, so we shouldnt look at them again
            continue;
        }
        else
        {
            result += current;
        }
    }
        return result;   
}
