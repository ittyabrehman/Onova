﻿using System;
using System.Text;

namespace Onova.Internal.Extensions
{
    internal static class StringExtensions
    {
        public static string SubstringUntil(this string s, string sub,
            StringComparison comparison = StringComparison.Ordinal)
        {
            var index = s.IndexOf(sub, comparison);
            return index < 0 ? s : s.Substring(0, index);
        }

        public static string SubstringAfter(this string s, string sub,
            StringComparison comparison = StringComparison.Ordinal)
        {
            var index = s.IndexOf(sub, comparison);
            return index < 0 ? string.Empty : s.Substring(index + sub.Length, s.Length - index - sub.Length);
        }

        public static byte[] GetBytes(this string input, Encoding encoding) => encoding.GetBytes(input);

        public static byte[] GetBytes(this string input) => input.GetBytes(Encoding.UTF8);

        public static string ToBase64(this byte[] data) => Convert.ToBase64String(data);
    }
}