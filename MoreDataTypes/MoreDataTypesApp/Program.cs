using System;
using System.Text;

namespace MoreDataTypesApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("How many apples?");
            //string input = Console.ReadLine();
            //int numApples = Int32.Parse(input);
            //var success = Int32.TryParse(input, out int parsedApples);

            //var myString = " C# list fundementals ";
            //Console.WriteLine(StringExercise(myString));
            //Console.WriteLine(StringBuilderExercise(myString));
            //StringInterpolation("Martin");
            //var num1 = 2;
            //var num2 = 7;
            //var fString = $"{num1} to the power of {num2} is {Math.Pow(num1, num2)}";
            //var fString2 = $"Log to the base {num2} of {num1} is {Math.Log(num2, num1):0####}";
            //var fString3 = $"That will be {num2 / 3.0:C} please!";

            //int[] myIntArray = { 12, 23, 34, 45, 56 };

            //Array.Reverse<int>(myIntArray);

            //foreach (var element in myIntArray)
            //{
            //    Console.WriteLine(element);
            //}
            //MultiDArrays();
            //JaggedArrays();

            //grid[0, 1] = 6; - multi d array
            //grid[0][1] = 6; - jagged array

            //DateTimeMethods();
            Enums();
            Enums2();
        }

        public enum Suit
        {
            HEARTS, CLUBS, DIAMONDS, SPADES
        }
        public static void Enums()
        {
            Suit theSuit = Suit.HEARTS;
            if (theSuit == Suit.SPADES)
            {
                Console.WriteLine($"The Suit is {Suit.SPADES}");
            }
            else
            {
                Console.WriteLine($"The Suit is {theSuit} not {Suit.SPADES}");
            }
            var mediumValue = (int)Size.MEDIUM;
            var mySize = (Size)50;

            var anotherSuit = Enum.Parse(typeof(Suit), "CLUBS");

        }
        public static void Enums2()
        {
            Suit theSuit = Suit.HEARTS;
            switch (theSuit)
            {
                case Suit.HEARTS:
                    Console.WriteLine("Thank You");
                    break;
                default:
                    Console.WriteLine("Goodbye");
                    break;
            }
        }

        public enum Size
        {
            SMALL = 10, MEDIUM = 25, LARGE = 50, XLARGE = 75
        }

        public static void




        public static void DateTimeMethods()
        {
            var now = DateTime.Now;
            Console.WriteLine($"The time is: {now}");
            Console.WriteLine($"In ticks this is: {now.Ticks}");
            var tomorrow = now.AddDays(1);
            Console.WriteLine($"Tomorrow it will be: {tomorrow} which is {tomorrow.Ticks}");
            now.
        }


        //public static void MultiDArrays()
        //{
        //    int[,] grid = new int[2, 4];
        //    grid[0, 1] = 6;
        //    grid[1, 0] = 8;
        //    grid[1, 3] = 10;


        //    char[,] gridTwo = { { 'a', 'b' },
        //                        { 'c', 'd' },
        //                        { 'e', 'f' },
        //                        { 'g', 'h' } };
        //    Console.WriteLine("All of grid two");

        //    foreach(var element in gridTwo)
        //    {
        //        Console.WriteLine($"{element}");
        //    }

        //    for (int i = gridTwo.GetLowerBound(0); i <= gridTwo.GetUpperBound(0); i++)
        //    {
        //        for (int j = gridTwo.GetLowerBound(1); j <= gridTwo.GetUpperBound(1); j++)
        //        {
        //            Console.WriteLine($"({i},{j}) {gridTwo[i, j]}  ");
        //        }
        //        Console.WriteLine();
        //    }
        //}
        
        //public static void JaggedArrays() // jagged array means not an even number of rows/cols - not square
        //{
        //    int[][] intJArray = new int[2][];
        //    intJArray[0] = new int[4];
        //    intJArray[1] = new int[2];

        //    intJArray[0][2] = 3;
        //    intJArray[1][0] = 5;

        //    string[][] animalJArray = new string[][]
        //    {
        //        new string[] { "llama", "puma", "horse", "kitten" },
        //        new string[] { "haddock", "tuna"}
        //    };
        //    Console.WriteLine("Jagged array animals");
        //    foreach(var row in animalJArray)
        //    {
        //        foreach(var entry in row)
        //        {
        //            Console.WriteLine($"{entry}");
        //        }
        //    }
            
        //}

        //public static void StringInterpolation(string str)
        //{
        //    Console.WriteLine("My name is : " + str + " using +"); // concatennation 
        //    Console.WriteLine($"My name is : {str} using interpolation"); // interpolation
        //}
        //public static string StringBuilderExercise(string myString)
        //{
        //    var trimmedUpperString = myString.Trim().ToUpper();
        //    var nPos = trimmedUpperString.IndexOf('N');
        //    StringBuilder sb = new StringBuilder(trimmedUpperString);
        //    sb.Replace('L', '*').Replace('T', '*').Remove(nPos + 1, (sb.Length - nPos - 1));
        //    return sb.ToString();
        //}

        //public static string StringExercise(string myString)
        //{
        //    var trimString = myString.Trim();
        //    var ucString = trimString.ToUpper();
        //    var replaceString = ucString.Replace('L', '*').Replace('T', '*');
        //    var nPos = replaceString.IndexOf('N');
        //    var finalString = replaceString.Remove(nPos + 1);
        //    return finalString;

            //var intermediateString = myString.Trim().ToUpper().Replace('L', '*').Replace('T', '*')'
            //var nPost = intermediateString.IndexOf('N');
            //var finalString = intermediateString.Remove(nPos + 1);
            //return finalString;
        }
    }

