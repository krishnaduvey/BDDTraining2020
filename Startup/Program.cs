using System;
using BDDTraining2020.FirstAssignment;
namespace Startup
{
    class Program
    {

        static string errorMessage = "Please Provide valid inputs and try again : Original Error Message is ";


        static void Main(string[] args)
        {

            Console.WriteLine("C# and BDD Training 2020 :");
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");

        InputValidNumber:

            if (DoYouWantToContinue())
            {
                Console.WriteLine();
                Console.WriteLine("Please use number 9 to skip all process and execute all Programs");
                Console.WriteLine("Please use Number 8 to get help.");
                Console.WriteLine("Question Number should be 1 to 7");
                Console.WriteLine("Please enter the Question Number :");
                int questionNumber = 0;

                try
                {
                    questionNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch (ArgumentNullException argNullExc)
                {
                    Console.WriteLine(argNullExc.Message);
                }
                catch (FormatException formExc)
                {
                    Console.WriteLine(formExc.Message);
                }
                catch (OverflowException overFloExc)
                {
                    Console.WriteLine(overFloExc.Message);
                }


                switch (questionNumber)
                {
                    case 1:
                        QuestionOne();
                        goto InputValidNumber;
                    case 2:
                        QuestionTwo();
                        goto InputValidNumber;
                    case 3:
                        QuestionThree();
                        goto InputValidNumber;
                    case 4:
                        QuestionFour();
                        goto InputValidNumber;
                    case 5:
                        QuestionFive();
                        goto InputValidNumber;
                    case 6:
                        QuestionSix();
                        goto InputValidNumber;
                    case 7:
                        QuestionSeven();
                        goto InputValidNumber;
                    case 8:
                        HelpForFirstAssignment();
                        goto InputValidNumber;
                    case 9:
                        ExecuteAll();
                        break;
                    default:
                        Console.WriteLine("Please provide valid number. \nFor know about questions enter 8. ");
                        goto InputValidNumber;
                }
            }
            else
                Environment.Exit(0);
        }
        public static bool DoYouWantToContinue()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Do you want to continue with this application :");
                Console.WriteLine("Please input Y/N : Y to Continue and N to Exit");
                //Console.WriteLine();
                char input = Console.ReadKey().KeyChar;
                var inputChar = Char.ToUpper(input);
                if (inputChar == 'Y')
                    return true;
                else if (inputChar == 'N')
                    return false;        
            }
            catch (Exception ex)
            {
                Console.WriteLine(errorMessage + "" + ex.Message);
            }

            return DoYouWantToContinue();
        }

        public static void HelpForFirstAssignment()
        {
            Console.WriteLine();
            Console.WriteLine("Please follow below numbers accordingly....");
            Console.WriteLine(" Enter 1 to check whether input year is leap year or not");
            Console.WriteLine(" Enter 2 to reverse strings each character from last to first");
            Console.WriteLine(" Enter 3 to reverse the integer Array");
            Console.WriteLine(" Enter 4 to heck whether input character is vowel or consonant");
            Console.WriteLine(" Enter 5 to reverse every words in a String");
            Console.WriteLine(" Enter 6 to print Armstrong numbers between a given range");
            Console.WriteLine(" Enter 7 to print pattern");
            Console.WriteLine(" Enter 8 to Help");
            Console.WriteLine();
            Console.WriteLine();

        }

        /// <summary>
        /// This method will execute all the programs in continuous way.
        /// </summary>
        public static void ExecuteAll() {
            Console.WriteLine();
            QuestionOne();
            Console.WriteLine();
            QuestionTwo();
            Console.WriteLine();
            QuestionThree();
            Console.WriteLine();
            QuestionFour();
            Console.WriteLine();
            QuestionFive();
            Console.WriteLine();
            QuestionSix();
            Console.WriteLine();
            QuestionSeven();
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void QuestionOne()
        {
            Console.WriteLine("Program 1: Write a Program to check whether input year is leap year or not.");
            try
            {
                Console.WriteLine("Please input a valid Year here...");
                int inputYear = Convert.ToInt32(Console.ReadLine());
                bool flag = Solutions.IsLeapYear(inputYear);
                if (!flag)
                    Console.WriteLine($"Year {inputYear} is not a Leap year", inputYear);
                else
                    Console.WriteLine($"Year {inputYear} is a Leap year", inputYear);
            }
            catch (Exception ex)
            {
                Console.WriteLine(errorMessage + "" + ex.Message);
            }

        }

        public static void QuestionTwo()
        {
            Console.WriteLine("Program 2: Write a Program to reverse string without using inbuilt function");
            try
            {
                Console.WriteLine("Please input a valid String here...");
                string inputString = Console.ReadLine();
                Console.WriteLine($"Input string before : {inputString}", inputString);
                string outputString = Solutions.ReverseStringByCharacter(inputString);
                Console.WriteLine($"Output string after : {outputString}", outputString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(errorMessage + "" + ex.Message);
            }
        }

        public static void QuestionThree()
        {
            Console.WriteLine("Program 3: Write a Program to reverse the Array without using inbuilt function");
            try
            {
                Console.WriteLine("Please provide the size of integer array.");
                int size = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Size of integer array that you want to create is {size}", size);
                int[] inputIntArray = new int[size];
                for (int i = 0; i < size; i++)
                {
                    inputIntArray[i] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Enter {i} element as {inputIntArray[i]} :", i, inputIntArray[i]);
                }

                Console.WriteLine("Array before :");
                foreach (int element in inputIntArray)
                    Console.Write(" " + element);

                Solutions.ReverseIntArray(inputIntArray);
                Console.WriteLine();
                Console.WriteLine("Array after :");
                foreach (int element in inputIntArray)
                    Console.Write(" " + element);
            }
            catch (Exception ex)
            {
                Console.WriteLine(errorMessage + "" + ex.Message);
            }

        }


        public static void QuestionFour()
        {
            Console.WriteLine("Program 4: Write a Program to check whether input character is vowel or consonant");
            try
            {
                Console.WriteLine("Please input a valid character here...");
                char inputChar = Console.ReadKey().KeyChar;
                bool flag = Char.IsLetter(inputChar);
                if (!flag)
                    Console.WriteLine("Please, Input a valid character");
                else {

                    Console.WriteLine();
                    if (!Solutions.IsVowel(inputChar))
                        Console.WriteLine("Input Character is not a vowel");
                    else
                        Console.WriteLine("Input Character is vowel");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(errorMessage + "" + ex.Message);
            }
        }

        public static void QuestionFive()
        {
            Console.WriteLine("Program 5: Write a Program to reverse every words in a String without using inbuilt function");
            try
            {
                Console.WriteLine("Please input a valid String here...");
                string inputString = Console.ReadLine();
                Console.WriteLine($"Input string before : {inputString}", inputString);
                string outputString = Solutions.ReverseStringWordByWord(inputString);
                Console.WriteLine($"Output string after : {outputString}", outputString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(errorMessage + "" + ex.Message);
            }
        }


        public static void QuestionSix()
        {
            Console.WriteLine("Program 6: Write a Program to print Armstrong numbers between a given range");
            try
            {
                Console.WriteLine("Please input first number...");
                int start= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please input second number...");
                int end= Convert.ToInt32(Console.ReadLine());
                if (start == 0 && end == 0)
                    Console.WriteLine("Try again.. with valid inputs.");
                else 
                Solutions.PrintArmstrongNumberWithinRange(start, end);
            }
            catch (Exception ex)
            {
                Console.WriteLine(errorMessage + "" + ex.Message);
            }

        }

        public static void QuestionSeven()
        {
            Console.WriteLine("Program 7: Write a Program to print pattern");
            try
            {
                Console.WriteLine("Please provide number of rows as input");
                Console.WriteLine("Please input number and enter here....");
                int inputRows = Convert.ToInt32(Console.ReadLine());
                Solutions.PrintPattern(inputRows);
            }
            catch (Exception ex)
            {
                Console.WriteLine(errorMessage + "" + ex.Message);
            }

        }


    }
}

