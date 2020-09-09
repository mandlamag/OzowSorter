using System;
using System.Text;
using System.Text.RegularExpressions;

public static class StringSorter
{
    public static string RemoveWhiteSpacesAndPunctuation(this string str)
    {
        return Regex.Replace(str, @"[^\w]", String.Empty);
    }

}