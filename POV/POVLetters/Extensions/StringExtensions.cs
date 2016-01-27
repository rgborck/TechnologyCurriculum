
using System;

namespace POVLetters.Extensions
{
  public static class StringExtensions
  {
    public static string FormatWith(this string initial, params object[] formatters) {
      return initial == null ? null : String.Format(initial, formatters);
    }

    public static bool IsNullOrWhiteSpace(this string me) {
      return string.IsNullOrWhiteSpace(me);
    }
  }
}
