using System;
using System.Collections.Generic;

namespace MoreTypes_Lib
{
    public class ArraysExercises
    {
        // returns a 1D array containing the contents of a given List
        public static string[] Make1DArray(List<string> contents)
        {
            return contents.ToArray();
            throw new NotImplementedException();
        }

        // returns a 3D array containing the contents of a given List
        public static string[,,] Make3DArray(int length1, int length2, int length3, List<string> contents)
        {

            throw new NotImplementedException();
        }

        // returns a jagged array containing the contents of a given List
        public static string[][] MakeJagged2DArray(int countRow1, int countRow2, List<string> contents)
        {
            if (contents.Count != countRow1 + countRow2)
            {
                throw new ArgumentException("Number of elements in list must match array size");
            }
            string[][] output = new string[][]
            {
                new string[countRow1],
                new string[countRow2]
            };

            int iterator = 0;
            foreach (var array in output)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = contents[iterator];
                    iterator++;
                }
            }
            return output;
        }
    }
}
