using System;
using System.Text;
using System.Text.RegularExpressions;

public static class StringSorter
{
    public static string RemoveWhiteSpacesAndPunctuation(this string input)
    {
        return Regex.Replace(input, @"[^\w]", String.Empty);
    }

    public static string ToSorted(this string input)
    {
        byte[] ascii = Encoding.ASCII.GetBytes(input);

        //could use OrderBy here but it felt like cheating.
        var sorted = SortBytesAscending(ascii);

        var results = string.Empty;

        foreach (byte c in sorted)
        {
            results += char.ConvertFromUtf32(c);
        }
        return results;
    }

    private static byte[] SortBytesAscending(byte[] asciiArray)
    {
        byte temp;

        for (int i = 0; i < asciiArray.Length - 1; i++)
        {
            for (int j = i + 1; j < asciiArray.Length; j++)
            {
                if (asciiArray[i] > asciiArray[j])
                {
                    temp = asciiArray[i];
                    asciiArray[i] = asciiArray[j];
                    asciiArray[j] = temp;
                }

            }
        }

        return asciiArray;
    }

}