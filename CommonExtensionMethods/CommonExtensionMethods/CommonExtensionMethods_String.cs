using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonExtensionMethods.QilongLiao
{
    public static class CommonExtensionMethods_String
    {
        public static IEnumerable<Byte> ToBytes(this string source, Encoding encoding = null)
        {
            if (encoding == null)
            {
                encoding = Encoding.Unicode;
            }

            if (!string.IsNullOrWhiteSpace(source))
            {
                return encoding.GetBytes(source);
            }
            return new byte[0];
        }

        public static bool IsNullOrWhiteSpace(this string source)
        {
            return string.IsNullOrWhiteSpace(source);
        }
        public static string IsNullOrWhiteSpace(this IEnumerable<string> source,)
        {
            return string.Join(source);
        }

    }
}
