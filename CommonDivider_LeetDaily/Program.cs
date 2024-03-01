class MyClass
{
    // Ограничения 1 < x <1000 ENG UPPERCASE
    static string a = "ABCABCABC";
    static string b = "ABAB";

    static void Main()
    {
        var s = GcdOfStrings(a, b);
    }

    private static string GcdOfStrings(string str1, string str2)
    {
        var maxDivider = "";

        var maxLength = str1.Length >= str2.Length ? str1.Length : str2.Length;
        for (var i = 1; i < maxLength -1; i++)
        {
            var first = Finder(str1, i);
            var second =  Finder(str2, i);
            // if (first.Equals(null) || second.Equals(null))
            // {continue;}
            
            if (first.Equals(second))
            {
                maxDivider = first;
            }
        }
        Console.WriteLine(maxDivider);
        return maxDivider;
    }
//validate divider
    private static string? Finder(string @string, int i)
    {
        if (@string.Length < i)
            return null;
        
        return @string.Substring(0, i);
    }
}