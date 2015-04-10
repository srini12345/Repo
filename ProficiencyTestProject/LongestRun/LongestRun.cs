using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LongestRun
{
    public class Run
    {
        /// <summary>
        /// Returns the Index of Longest Repeated char in a string
        /// </summary>
        /// <param name="str">input String</param>
        /// <returns>Index postin in Integer</returns>
        public static int IndexOfLongestRun(string str)
        {
           

            char[] givenArrayString = str.ToCharArray();

            char current = ' '; // Setting up current and prev chars
            char prevchar = ' ';
            int count = 0;

            char ActualChar = prevchar; 
            int MaxCount = count;   // Max value of a repeated char
            int ActaulIndex = 0;

            for (int i = 0; i < givenArrayString.Length; i++)
            {
                current = givenArrayString[i];  
                if (current == prevchar)    // continuous repeated char so increase the counter
                {
                    count++;
                }
                else
                {
                    prevchar = current; //Non repeated char so settingup counter to 1
                    count = 1;
                }

                if (count > MaxCount)   // check if next counter is greated than previous Max char 
                {
                    MaxCount = count;
                    ActualChar = current;   //Assign the longest char
                   
                }


            }

            ActaulIndex = str.IndexOf(ActualChar);  // get the First index of Longest char

            return ActaulIndex;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(IndexOfLongestRun("abbcccddddcccbba"));
            Console.ReadKey();
        }
    }
}
