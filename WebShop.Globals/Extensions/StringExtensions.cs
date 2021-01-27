using System;

namespace WebShop.Commons.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNull(this string str)
        {
            return String.IsNullOrEmpty(str);
        }
    }
}