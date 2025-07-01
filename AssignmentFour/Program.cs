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

            #region 18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
            //  -If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
            //  - If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            //  - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
            // - If the worker takes more than 5 hours, they are required to leave the company.
            //    To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.

            //Console.Write("Enter time taken to complete the task (in hours): ");
            //double time = Convert.ToDouble(Console.ReadLine());

            //if (time >= 2 && time <= 3)
            //{
            //    Console.WriteLine("Highly efficient.");
            //}
            //else if (time > 3 && time <= 4)
            //{
            //    Console.WriteLine("You need to increase your speed.");
            //}
            //else if (time > 4 && time <= 5)
            //{
            //    Console.WriteLine("You will be given training to improve your speed.");
            //}
            //else if (time > 5)
            //{
            //    Console.WriteLine("You are required to leave the company.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Time must be 2 hours or more.");
            //}

            #endregion

            #region 19- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.Write("Enter the size of the identity matrix (n): ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Identity Matrix of size {0} x {0}:", n);

            //for (int row = 0; row < n; row++)
            //{
            //    for (int col = 0; col < n; col++)
            //    {
            //        if (row == col)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 20- Write a program in C# Sharp to find the sum of all elements of the array.
            //Console.Write("Enter the number of elements in the array: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] numbers = new int[n];
            //int sum = 0;


            //Console.WriteLine("Enter {0} elements:", n);
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Element [{0}]: ", i);
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //    sum += numbers[i];
            //}


            //Console.WriteLine("The sum of all elements in the array is: " + sum);
            #endregion

            #region 21- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //Console.Write("Enter size of the arrays: ");
            //int size = Convert.ToInt32(Console.ReadLine());

            //int[] array1 = new int[size];
            //int[] array2 = new int[size];
            //int[] mergedArray = new int[size * 2];

            //// Input for first array
            //Console.WriteLine("Enter elements of first array:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write("Element [{0}]: ", i);
            //    array1[i] = Convert.ToInt32(Console.ReadLine());
            //    mergedArray[i] = array1[i]; 
            //}


            //Console.WriteLine("Enter elements of second array:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write("Element [{0}]: ", i);
            //    array2[i] = Convert.ToInt32(Console.ReadLine());
            //    mergedArray[size + i] = array2[i]; 
            //}


            //Array.Sort(mergedArray);


            //Console.WriteLine("\nMerged and Sorted Array:");
            //foreach (int num in mergedArray)
            //{
            //    Console.Write(num + " ");
            //}
            #endregion

            #region 22- Write a program in C# Sharp to count the frequency of each element of an array.
            //Console.Write("Enter the number of elements in the array: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] array = new int[n];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element [{i}]: ");
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}


            //Dictionary<int, int> frequency = new Dictionary<int, int>();

            //foreach (int value in array)
            //{
            //    if (frequency.ContainsKey(value))
            //    {
            //        frequency[value]++;
            //    }
            //    else
            //    {
            //        frequency[value] = 1;
            //    }
            //}

            //Console.WriteLine("\nFrequency of each element:");
            //foreach (var item in frequency)
            //{
            //    Console.WriteLine($"Element {item.Key} occurs {item.Value} time(s)");
            //}
            #endregion

            #region 23- Write a program in C# Sharp to find maximum and minimum element in an array
            //Console.Write("Enter the number of elements in the array: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] array = new int[n];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element [{i}]: ");
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int max = array[0];
            //int min = array[0];

            //for (int i = 1; i < n; i++)
            //{
            //    if (array[i] > max)
            //        max = array[i];

            //    if (array[i] < min)
            //        min = array[i];
            //}

            //Console.WriteLine("\nMaximum element = " + max);
            //Console.WriteLine("Minimum element = " + min);
            #endregion

            #region 24- Write a program in C# Sharp to find the second largest element in an array.
            //Console.Write("Enter number of elements in the array: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //if (n < 2)
            //{
            //    Console.WriteLine("Array must have at least two elements.");
            //    return;
            //}

            //int[] arr = new int[n];

            //Console.WriteLine("Enter array elements:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element [{i}]: ");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int first = int.MinValue;
            //int second = int.MinValue;

            //foreach (int num in arr)
            //{
            //    if (num > first)
            //    {
            //        second = first;
            //        first = num;
            //    }
            //    else if (num > second && num != first)
            //    {
            //        second = num;
            //    }
            //}

            //if (second == int.MinValue)
            //{
            //    Console.WriteLine("There is no second largest element (all elements are equal).");
            //}
            //else
            //{
            //    Console.WriteLine("Second largest element is: " + second);
            //}
            #endregion

            #region 25-. Consider an Array of Integer values with size N, having values as in this Example
            //Console.Write("Enter the number of elements in the array: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] arr = new int[n];

            //Console.WriteLine("Enter the array elements:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element [{i}]: ");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Dictionary<int, int> firstIndex = new Dictionary<int, int>();
            //int maxDistance = -1;

            //for (int i = 0; i < n; i++)
            //{
            //    int value = arr[i];
            //    if (!firstIndex.ContainsKey(value))
            //    {
            //        // Store the first occurrence of the value
            //        firstIndex[value] = i;
            //    }
            //    else
            //    {
            //        int distance = i - firstIndex[value] - 1; // exclude endpoints
            //        if (distance > maxDistance)
            //        {
            //            maxDistance = distance;
            //        }
            //    }
            //}

            //if (maxDistance == -1)
            //{
            //    Console.WriteLine("No repeated elements found.");
            //}
            //else
            //{
            //    Console.WriteLine("The longest distance between two equal values is: " + maxDistance);
            //}
            #endregion

            #region 26- Given a list of space separated words, reverse the order of the words.
            //Console.Write("Enter a sentence: ");
            //string input = Console.ReadLine();


            //Console.WriteLine(string.Join(" ", input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse()));
            #endregion

            #region 27- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            //Console.Write("Enter number of rows: ");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter number of columns: ");
            //int cols = Convert.ToInt32(Console.ReadLine());

            //int[,] array1 = new int[rows, cols];
            //int[,] array2 = new int[rows, cols];


            //Console.WriteLine("Enter values for the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"Element [{i},{j}]: ");
            //        array1[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}


            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        array2[i, j] = array1[i, j];
            //    }
            //}


            //Console.WriteLine("\nSecond array after copying:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(array2[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 28- Write a Program to Print One Dimensional Array in Reverse Order
            //Console.Write("Enter number of elements in the array: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] array = new int[n];

            //Console.WriteLine("Enter array elements:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element [{i}]: ");
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("\nArray in reverse order:");
            //for (int i = n - 1; i >= 0; i--)
            //{
            //    Console.Write(array[i] + " ");
            //}

            //Console.WriteLine(); 
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
