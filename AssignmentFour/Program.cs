using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AssignmentFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number % 3 == 0 && number % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            #endregion

            #region 2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.Write("Enter an integer: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number < 0)
            //{
            //    Console.WriteLine("negative");
            //}
            //else
            //{
            //    Console.WriteLine("positive");
            //}
            #endregion

            #region 3- Write a program that takes 3 integers from the user then prints the max element and the min element.
            //Console.Write("Enter first number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter third number: ");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //int max = num1;
            //int min = num1;

            //if (num2 > max) max = num2;
            //if (num3 > max) max = num3;

            //if (num2 < min) min = num2;
            //if (num3 < min) min = num3;

            //Console.WriteLine("Max element = " + max);
            //Console.WriteLine("Min element = " + min);

            #endregion

            #region 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.Write("Enter an integer: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}
            #endregion

            #region 5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Console.Write("Enter a character: ");
            //char ch = Convert.ToChar(Console.ReadLine());


            //ch = Char.ToLower(ch);

            //if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            //{
            //    Console.WriteLine("vowel");
            //}
            //else if (Char.IsLetter(ch))
            //{
            //    Console.WriteLine("consonant");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input (not a letter)");
            //}

            #endregion

            #region 6 - Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.Write("Enter an integer: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number >= 1)
            //{
            //    for (int i = 1; i <= number; i++)
            //    {
            //        if (i != number)
            //            Console.Write(i + ", ");
            //        else
            //            Console.Write(i); // No comma after the last number
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a number greater than or equal to 1.");
            //}

            #endregion

            #region 7- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.Write("Enter an integer: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(number * i + " ");
            //}

            #endregion

            #region 8- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 2; i <= number; i += 2)
            //{
            //    Console.Write(i + " ");
            //}

            #endregion

            #region 9- Write a program that takes two integers then prints the power.

            //Console.Write("Enter the base number: ");
            //int baseNumber = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the exponent: ");
            //int exponent = Convert.ToInt32(Console.ReadLine());

            //int result = 1;

            //for (int i = 1; i <= exponent; i++)
            //{
            //    result *= baseNumber;
            //}

            //Console.WriteLine("Output: " + result);
            #endregion

            #region 10- Write a program to enter marks of five subjects and calculate total, average and percentage.
            //int[] marks = new int[5];
            //int total = 0;

            //Console.WriteLine("Enter marks of five subjects:");

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"Subject {i + 1}: ");
            //    marks[i] = Convert.ToInt32(Console.ReadLine());
            //    total += marks[i];
            //}

            //double average = total / 5.0;
            //double percentage = average; // Assuming each subject is out of 100

            //Console.WriteLine("Total marks = " + total);
            //Console.WriteLine("Average Marks = " + average);
            //Console.WriteLine("Percentage = " + percentage);

            #endregion

            #region 11- Write a program to input the month number and print the number of days in that month.
            //Console.Write("Enter month number (1-12): ");
            //int month = Convert.ToInt32(Console.ReadLine());

            //int days;

            //if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            //{
            //    days = 31;
            //}
            //else if (month == 4 || month == 6 || month == 9 || month == 11)
            //{
            //    days = 30;
            //}
            //else if (month == 2)
            //{
            //    days = 28; // Not checking leap year here
            //}
            //else
            //{
            //    Console.WriteLine("Invalid month number.");
            //    return;
            //}

            //Console.WriteLine("Days in Month: " + days);

            #endregion

            #region 12- Write a program to create a Simple Calculator.
            //double num1, num2, result = 0;
            //char operation;

            //Console.Write("Enter first number: ");
            //num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter an operator (+, -, *, /): ");
            //operation = Convert.ToChar(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //num2 = Convert.ToDouble(Console.ReadLine());

            //bool validOperation = true;

            //switch (operation)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;

            //    case '-':
            //        result = num1 - num2;
            //        break;

            //    case '*':
            //        result = num1 * num2;
            //        break;

            //    case '/':
            //        if (num2 != 0)
            //            result = num1 / num2;
            //        else
            //        {
            //            Console.WriteLine("Error: Cannot divide by zero.");
            //            validOperation = false;
            //        }
            //        break;

            //    default:
            //        Console.WriteLine("Invalid operator.");
            //        validOperation = false;
            //        break;
            //}

            //if (validOperation)
            //{
            //    Console.WriteLine("Result: " + result);
            //}
            #endregion

            #region 13- Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //string reversed = "";

            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    reversed += input[i];
            //}

            //Console.WriteLine("Reversed string: " + reversed);
            #endregion

            #region 14 - Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.Write("Enter an integer: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int reversed = 0;

            //while (number != 0)
            //{
            //    int digit = number % 10;
            //    reversed = reversed * 10 + digit;
            //    number /= 10;
            //}

            //Console.WriteLine("Reversed number: " + reversed);
            #endregion

            #region 15- Write a program in C# Sharp to find prime numbers within a range of numbers.
            //    Console.Write("Input starting number of range: ");
            //    int start = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Input ending number of range: ");
            //    int end = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("The prime numbers between {0} and {1} are:", start, end);

            //    for (int num = start; num <= end; num++)
            //    {
            //        if (IsPrime(num))
            //        {
            //            Console.Write(num + " ");
            //        }
            //    }
            //}

            //static bool IsPrime(int number)
            //{
            //    if (number < 2) return false;

            //    for (int i = 2; i <= Math.Sqrt(number); i++)
            //    {
            //        if (number % i == 0)
            //            return false;
            //    }

            //    return true;
            #endregion

            #region 16- . Write a program in C# Sharp to convert a decimal number into binary without using an array.

            //Console.Write("Enter a number to convert: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //string binary = "";

            //int temp = number;

            //if (number == 0)
            //{
            //    binary = "0";
            //}
            //else
            //{
            //    while (number > 0)
            //    {
            //        int remainder = number % 2;
            //        binary = remainder + binary; // Prepend each bit
            //        number = number / 2;
            //    }
            //}

            //Console.WriteLine("The Binary of {0} is {1}.", temp, binary);
            #endregion

            #region 17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //Console.Write("Enter x1: ");
            //double x1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter y1: ");
            //double y1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter x2: ");
            //double x2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter y2: ");
            //double y2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter x3: ");
            //double x3 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter y3: ");
            //double y3 = Convert.ToDouble(Console.ReadLine());


            //double area = 0.5 * Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

            //if (area == 0)
            //{
            //    Console.WriteLine("The points lie on the same straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do NOT lie on the same straight line.");
            //}
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

        }
    }
}
