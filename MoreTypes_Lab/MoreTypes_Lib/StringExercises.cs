using System;
using System.Text;
using System.Linq;

namespace MoreTypes_Lib
{
    public class StringExercises
    {
        // manipulates and returns a string - see the unit test for requirements
        public static string ManipulateString(string input, int num)
        {
            var trimString = input.Trim();
            var ucString = trimString.ToUpper();
            for (int i = 0; i < num; i++)
            {
                ucString += i;
            }
            return ucString;
            throw new NotImplementedException();
        }

        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            return ($"{number} {street}, {city} {postcode}.");
            throw new NotImplementedException();
        }
        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf)
        {
            double percent = ((Convert.ToDouble(score) / Convert.ToDouble(outOf)) * 100);
            return ($"You got {score} out of {outOf}: {Math.Round(percent,1)}%");
            throw new NotImplementedException();
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {
            bool success = double.TryParse(numString, out double result);
            if (success)
            {
                double parsedString = double.Parse(numString);
                return parsedString;
            }
            else
            {
                return -999;
            }
            throw new NotImplementedException();
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            int count = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            foreach (char A in input)
            {
                if (A == 'A')
                    count++;
            }
            foreach (char B in input)
            {
                if (B == 'B')
                    count2++;
            }
            foreach (char C in input)
            {
                if (C == 'C')
                    count3++;
            }
            foreach (char D in input)
            {
                if (D == 'D')
                    count4++;
            }
            return ($"A:{count} B:{count2} C:{count3} D:{count4}");
            throw new NotImplementedException();
        }
    }
}
