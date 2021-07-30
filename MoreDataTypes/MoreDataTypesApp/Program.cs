using System;

namespace MoreDataTypesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myString = " C# list fundementals ";
            Console.WriteLine(StringExercise(myString));
        }
        public static string StringExercise(string myString)
        {
            var trimString = myString.Trim();
            var ucString = trimString.ToUpper();
            var replaceString = ucString.Replace('L', '*').Replace('T', '*');
            var nPos = replaceString.IndexOf('N');
            var finalString = replaceString.Remove(nPos + 1);
            return finalString;
        }
    }
}
