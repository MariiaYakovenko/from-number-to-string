using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace с_числа_в_строку
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Input a number (from 0 to 999): ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    string number_str = number.ToString();
                    number_str.Trim();
                    Console.WriteLine(NumberToText(number_str));
                    Console.WriteLine("Would you like to continue?\n1=yes\nany key=no");
                    int.TryParse(Console.ReadLine(), out int cont);
                    if (cont != 1) break;
                }
                else
                    Console.WriteLine("The input data is not an integer.");
            } while (true);
        }

        private static string Two_Digits(char c)
        {
            string answer = "";
            switch (c)
            {
                case '2':
                    answer = "twenty";
                    break;
                case '3':
                    answer = "thirty";
                    break;
                case '4':
                    answer = "forty";
                    break;
                case '5':
                    answer = "fifty";
                    break;
                case '6':
                    answer = "sixty";
                    break;
                case '7':
                    answer = "seventy";
                    break;
                case '8':
                    answer = "eighty";
                    break;
                case '9':
                    answer = "ninety";
                    break;
                default:
                    break;
            }
            return answer;
        }

        //___________________________________________________
        private static string One_Digit(char c)
        {
            string answer = "";
            switch (c)
            {
                case '0':
                    answer = "zero";
                    break;
                case '1':
                    answer = "one";
                    break;
                case '2':
                    answer = "two";
                    break;
                case '3':
                    answer = "three";
                    break;
                case '4':
                    answer = "four";
                    break;
                case '5':
                    answer = "five";
                    break;
                case '6':
                    answer = "six";
                    break;
                case '7':
                    answer = "seven";
                    break;
                case '8':
                    answer = "eight";
                    break;
                case '9':
                    answer = "nine";
                    break;
                default:
                    break;
            }
            return answer;
        }
        //____________________
        private static string Teens(string number_str)
        {
            string answer = "";
            if (number_str[1] == '0')
                answer = "ten";
            else if (number_str[1] == '1')
                answer = "eleven";
            else if (number_str[1] == '2')
                answer = "twelve";
            else if (number_str[1] == '3')
                answer = "thirteen";
            else if (number_str[1] == '4')
                answer = "fourteen";
            else if (number_str[1] == '5')
                answer = "fifteen";
            else if (number_str[1] == '6')
                answer = "sixteen";
            else if (number_str[1] == '7')
                answer = "seventeen";
            else if (number_str[1] == '8')
                answer = "eighteen";
            else
                answer = "nineteen";
            return answer;
        }
        //_________________________
        private static string NumberToText(string number_str)
        {
            int length = number_str.Length;
            string answer = "";
            if (number_str[0] == '-' || length > 3)
                return "The input number is not in range from 0 to 999";


            if (length == 1)
            {
                answer = $"{One_Digit(number_str[0])}";

            }
            else if (length == 2)
            {
                if (number_str[0] != '1')
                    answer = $"{Two_Digits(number_str[0])}-{One_Digit(number_str[1])}";
                else
                    answer = $"{Teens(number_str)}";
            }
            else if (length == 3)
            {
                if (number_str[2] == '0')
                    answer = $"{One_Digit(number_str[0])} hundred {Two_Digits(number_str[1])}";
                else
                    answer = $"{One_Digit(number_str[0])} hundred and {Two_Digits(number_str[1])} {One_Digit(number_str[2])}";
            }
            return answer;
        }
    }
}
