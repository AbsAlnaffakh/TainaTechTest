using System.Text.RegularExpressions;

namespace TainaTechTest.Extensions
{
    /// <summary>
    /// Provides a number of string extension methods
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Ensure that a string has a valid value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool HasValue(this string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        /// <summary>
        /// Checks if the string is representative of an internation phone number
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsContactNumber(this string value)
        {
            try
            {
                return Regex.IsMatch(value, "/([0-9\\s\\-]{7,})(?:\\s*(?:#|x\\.?|ext\\.?|extension)\\s*(\\d+))?$/");
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if the string is representative of a valid email address
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsEmailAddress(this string value)
        {
            try
            {
                return Regex.IsMatch(value, "^([a-zA-Z0-9_\\-\\.]+)@([a-zA-Z0-9_\\-\\.]+)\\.([a-zA-Z]{2,5})$");
            }
            catch
            {
                return false;
            }
        }
    }
}