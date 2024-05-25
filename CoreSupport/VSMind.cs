using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopSupport
{
    public static class VSMind
    {
        public static decimal Val(string Value)
        {
            return Value.DecimalOrDefault();
        }

        public static string UCase(string Value)
        {
            return Value.ToUpper();
        }

        public static string Format(string Value, params object[] Format)
        {
            return string.Format(Value, Format);
        }

        public static string LCase(string Value)
        {
            return Value.ToLower();
        }

        public static int Len(string Value)
        {
            return Value.Length;
        }

        public static string Join(string Seperator, params string[] Value)
        {
            return string.Join(Seperator, Value);
        }

        public static string Trim(string Value)
        {
            return Value.Trim();
        }

        public static string Mid(string Value, int Start, int Length = 1)
        {
            if (Start <= 0 || Length <= 0) return "";

            return Value.Substring(Start - 1, Length);
        }

        public static string Replace(string Value, string TargetValue, string ReplaceValue)
        {
            return Value.Replace(TargetValue, ReplaceValue);
        }

        //public static string Split()
    }
}
