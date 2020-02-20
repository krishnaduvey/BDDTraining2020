using System;
using System.Collections.Generic;
using System.Text;

namespace BDDTraining2020.FirstAssignment
{
    public class Solutions
    {

        /// <summary>
        /// Question 1 : Please check whether input year is leap year or not.
        /// Leap year is a year in which 366 days.
        /// This Methods works on checking year is Leap or not.
        /// </summary>
        /// <code>
        /// Internally it works as
        /// if(year%400==0)
        /// return true;
        /// else if(year%4==0)
        /// {
        /// if(year%100==0)
        /// return true;
        /// else 
        /// return false
        /// }
        /// else
        /// return false;
        /// <code>
        /// <param name="year"></param>
        /// <returns></returns>
        public static bool IsLeapYear(int year) // taking year as unsigned int which have max range near by 6k
        {
            return (year % 400 == 0) ? true : (year % 4 == 0) ? (year % 100 != 0) : false ? true : false; // using ternary operator
        }


      
        /// <summary>
        /// This method used to reversing a string character wise.
        /// </summary>
        /// <param name="inputString"> It defines a string that will be converted in to reverse order. </param>
        /// <returns> Returns output in string.</returns>
        public static string ReverseStringByCharacter(string inputString)
        {
            int length = inputString.Length;
            if (length <= 0)
                return inputString;
            string outputString = "";
            while (length > 0)
            {
                outputString += inputString[length - 1]; // like reverse loop, character will append to output string from last to end.
                length--;
            }
            return outputString;
        }



        /// <summary>
        /// Just to take an integer array as input and reverse the posion
        /// </summary>
        /// <param name="inputArray"> array which contains all integer elements</param>
        /// <returns> returning array in reverse order as output </returns>
        public static int[] ReverseIntArray(int[] inputArray)
        {
            if (inputArray.Length == 1)
                return inputArray;
            int length = inputArray.Length - 1;
            for (int i = 0; i < length; i++)
            {
                SwapNumbers(inputArray, i, length);
                length--;
            }
            return inputArray;
        }



        /// <summary>
        /// Just to swap between positions of two value.
        /// </summary>
        /// <param name="inputArray"> array which contains all integer elements</param>
        /// <param name="i"> current index number, where our loop is on</param>
        /// <param name="length"> position at which we need to swap the current value</param>
        public static void SwapNumbers(int[] inputArray, int i, int length)
        {
            int temp = inputArray[i];
            inputArray[i] = inputArray[length];
            inputArray[length] = temp;
        }


        /// <summary>
        /// Question 4 : check whether input character is vowel or consonant.
        /// </summary>
        /// <code>
        ///"aeiouAEIOU".IndexOf(c) >= 0; //We can check by character present on any index it will return its index number, then check with greater n equal to zero, so return true or false 
        /// <code>
        /// <param name="inputChar"></param>
        /// <returns></returns>
        public static bool IsVowel(char inputChar)
        {
            if (inputChar == 'a' || inputChar == 'e' || inputChar == 'i' || inputChar == 'o' || inputChar == 'u')
                return true;

            return false;


        }



        /// <summary>
        /// Quation 5 : This method is working on string reverse per word.
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns>It retruns a new string which is in the reverse form</returns>
        public static string ReverseStringWordByWord(string inputString)
        {
            string outputString = "";// used as output string
            string tempString = ""; // Temporary string to fetch words from string
            if (inputString.Length <= 0)
                return inputString;
            int i = 0;
            int lastIndex = inputString.Length - 1;

            do
            {
                tempString += inputString[i];
                if (inputString[i] == ' ' || i == lastIndex)
                {
                    outputString += ReverseStringByCharacter(tempString) + inputString[i]; // internally, it will reuse the method which reversing a string by character
                    tempString = "";
                }
                i++;
            }
            while (i < inputString.Length);

            return outputString;
        }

        /// <summary>
        /// Question 6: Program to print Armstrong numbers between a given range
        /// </summary>
        /// <param name="number"> Input number that we want to check</param>
        /// <returns>returns output in true or false</returns>
        public static bool IsArmStrongNumber(int number)
        {
            int sum = 0;
            int input = number;
            while (number > 0)
            {
                int digit = number % 10; // take last digit
                number = number / 10; // remove last digit from number
                sum += (digit * digit * digit); //take cube of digit and added into a variable
            }

            if (sum == input)
                return true;
            else return false;
        }

        /// <summary>
        /// Get the number info, print number is armstrong or not?
        /// </summary>
        /// <param name="start"> Initial number </param>
        /// <param name="end"></param>
        public static void PrintArmstrongNumberWithinRange(int start, int end) {
            bool flag;

            if (start > end)
            {
                int temp = start;
                start = end;
                end = temp;
            }

            for( ; start<=end; start++)
            {
                flag=IsArmStrongNumber(start);
                if (flag)
                    Console.WriteLine($"{start} is Armstrong Number",start);
            }
         }

        /// <summary>
        /// Question 7 : Print Pattern.
        /// </summary>
        /// <param name="rows"> Enter number of rows that you want to print.</param>
        public static void PrintPattern(int rows)
        {
            int outer, inner;
            int stars = 1;
            int spaces = rows - 1;

            for (outer = 1; outer < rows * 2; outer++) // 
            {
                for (inner = 1; inner <= spaces; inner++) // print single space frome 1 to space
                    Console.Write(" ");
                for (inner = 1; inner < stars * 2; inner++) //inner loop from 1 to stars*2-1 to print star
                    Console.Write("*");
                Console.WriteLine();

                if (outer < rows)
                {
                    spaces--; //
                    stars++;
                }
                else
                {
                    spaces++;
                    stars--;
                }
            }

        }
    }
}
