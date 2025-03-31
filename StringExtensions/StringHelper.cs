using System;

namespace StringExtensions
{
    public static class StringHelper
    {
        public static bool StartsWithUpper(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;

            return char.IsUpper(value[0]);
        }
    }
}
