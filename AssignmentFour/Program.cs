using Microsoft.VisualBasic;
using System.Globalization;
using System.IO.Pipes;
using System.Text;


namespace AssignmentFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Control Statements
            #region conditional statements -Example 1 [quarter]

            Console.WriteLine("please enter a number ");
            int.TryParse(Console.ReadLine(), out int age);
            //if  (age > 22)
            //    Console.WriteLine("Age >22");
            //else if (age < 22)
            //    Console.WriteLine("Age < 22");
            //else
            //    Console.WriteLine("Age = 22");

            //switch (age)
            //{
            //    case 22:
            //        Console.WriteLine("Age = 22");
            //        break;
            //    case > 22:
            //        Console.WriteLine("Age > 22");
            //        break;
            //    case < 22:
            //        Console.WriteLine("Age < 22");
            //        break;
            //    default:
            //        Console.WriteLine("Age is not a number");
            //        break;
            //}




            #endregion
            #region conditional statements -Example 2 [Name - Hello Name]
            //Console.WriteLine("Please enter your name");
            //string name = Console.ReadLine();
            //if( name == "Mariam")
            //    Console.WriteLine("Hello Mariam");
            //else if (name == "Ahmed")
            //    Console.WriteLine("Hello Ahmed");
            //else if (name == "Ali")
            //    Console.WriteLine("Hello Ali");
            //else
            //    Console.WriteLine("Hello stranger");
            //switch (name)
            //{
            //    case "Mariam":
            //        Console.WriteLine("Hello Mariam");
            //        break;
            //    case "Ahmed":
            //        Console.WriteLine("Hello Ahmed");
            //        break;
            //    case "Ali":
            //        Console.WriteLine("Hello Ali");
            //        break;
            //    default:
            //        Console.WriteLine("Hello stranger");
            //        break;
            //}

            #endregion
            #region conditional statements -Example 3 [budget] - [switch]
            //1000==> Option 1
            //2000==> Option 2 ,option 1
            //3000==> Option 3 ,option 2, option 1
            //Console.WriteLine("Please enter your budget");
            //int.TryParse(Console.ReadLine(), out int budget);
            //if (budget == 1000)
            //{
            //    Console.WriteLine("Option 1");
            //}
            //else if (budget == 2000)
            //{
            //    Console.WriteLine("Option 2");
            //    Console.WriteLine("Option 1");
            //}
            //else if (budget == 3000)
            //{
            //    Console.WriteLine("Option 3");
            //    Console.WriteLine("Option 2");
            //    Console.WriteLine("Option 1");
            //}
            //else
            //{
            //    Console.WriteLine("No options available");
            //}
            //switch (budget)
            //{
            //    case 1000:
            //        Console.WriteLine("Option 1");
            //        break;
            //    case 2000:
            //        Console.WriteLine("Option 2");
            //        Console.WriteLine("Option 1");
            //        goto case 1000;
            //        break;
            //    case 3000:
            //        Console.WriteLine("Option 3");
            //        Console.WriteLine("Option 2");
            //        Console.WriteLine("Option 1");
            //        goto case 2000;
            //        break;
            //    default:
            //        Console.WriteLine("No options available");
            //        break;
            //}

            //Hamada:
            //    Console.WriteLine("Hello ya hamada");
            //    Console.WriteLine("Please enter your number");
            //    int.TryParse(Console.ReadLine(), out int number);
            //    goto Hamada;



            #endregion
            #endregion
            #region switch c# 7.0 [pattern matching - when keyword]
            #region pattern matching 
            ////[object - integer - double]
            //object obj;
            ////allocate 4 bytes of memory
            //obj =10; 
            //switch (obj)
            //{
            //    case int x when x >10 && x>=5 :
            //        Console.WriteLine("integer");
            //        break;
            //        case float x:
            //        Console.WriteLine("float");
            //        break;
            //        case double x:
            //        Console.WriteLine("double");
            //        break;
            //        default:
            //        Console.WriteLine("unknown type");
            //        break;
            //}

            #endregion
            #region user defined types
            //object obj = new person() {Id = 1, Name = "Hamada" , Age =20 };
            //switch (obj)
            //{
            // case int input:
            //     Console.WriteLine("integer");
            //     break;
            // case float input:
            //     Console.WriteLine("float");
            //     break;
            // case person input:
            //     Console.WriteLine("person");
            //     break;
            // default:
            //     Console.WriteLine("unknown type");
            //     break;
            //}

            #endregion
            #endregion
            #region switch c# 8.0
            #region pattern matching without alias
            //[object , integer , double]
            //object obj = 10;
            //switch (obj)
            //{
            //    case int:
            //        Console.WriteLine("integer");
            //        break;
            //    case float:
            //        Console.WriteLine("float");
            //        break;
            //    default:
            //        Console.WriteLine("unknown data type");
            //        break;
            //}


            #endregion
            #region  switch case before pattern matching
            //1=> msg = option 1
            //int number;
            //string result;
            //Console.WriteLine("please enter the number [1,2,3]");
            //int.TryParse(Console.ReadLine(), out number);
            //switch(number)
            //{
            //    case 1:
            //        result = "option 1";
            //        break;
            //    case 2:
            //        result = "option 2";
            //        break;
            //    case 3:
            //        result = "option 3";
            //        break;
            //    default:
            //        result = "unknown option";
            //        break;
            //}
            //Console.WriteLine(result);


            #endregion
            #region switch expression [constant pattern-discard pattern]
            ////1=> msg = option 1
            //int number;
            //Console.WriteLine("please enter the number [1,2,3]");
            //int.TryParse(Console.ReadLine(), out number);
            //string result = number switch
            //{
            //    1 => "option 1", // constant pattern
            //    2 => "option 2",
            //    3 => "option 3",
            //    _ => "unknown option"  // discard pattern
            //};
            //Console.WriteLine(result);
            #endregion

            #region property pattern
            //person
            //person person = new person() { Id = 10, Name = "Hamada", Age = 20 };
            //string result = person switch
            //{
            //    { Id: 10, Name: "Hamada" } => "Hello Hamada",
            //    { Id: 20, Name: "Ahmed" } => "Hello Ahmed",
            //    { Id: 30, Name: "Ali" } => "Hello Ali",
            //    _ => "Hello stranger"
            //};
            //Console.WriteLine(result);


            #endregion

            #region Nullable reference type
            ////int? number = null;
            //int? number = null;
            //string result = number switch
            //{
            //    null => "number is null",
            //    int x when x >0 => "number is greater than 0",
            //    int y when y <0 => "number is less than 0",
            //    _ => "zero"
            //};
            //Console.WriteLine(result);

            #endregion
            #endregion
            #region switch c# 9.0
            #region Relational pattern
            //num < 10,between 10 and 20, >20
            //Console.WriteLine("Please enter a number");
            //int.TryParse(Console.ReadLine(), out int number);
            //string result = number switch
            //{
            //    < 10 => "number is less than 10",
            //    >= 10 and <= 20 => "number is between 10 and 20",
            //    > 20 => "number is greater than 20",
            //    _ => "unknown number"
            //};
            //Console.WriteLine(result);
            #endregion
            #region Enhanced property pattern
            //person is samyy & age >10
            //person is omar & age between 20 and 30
            //person's age is between 40 and 50
            //else ==> unknown person
            //person person = new person() { Id = 10, Name = "Hamada", Age = 20 };

            //string result = person switch
            //{
            //    { Name: "Samyy", Age: > 10 } => "Hello Samyy",
            //    { Name: "Omar", Age: >= 20 and <= 30 } => "Hello Omar",
            //    { Age: >= 40 and <= 50 } => "Hello person with age between 40 and 50",
            //    _ => "Hello stranger"
            //};
            //Console.WriteLine(result);

            #endregion
            #endregion
            #region looping statements [for , foreach]
            #region intro
            //Console.WriteLine(0);
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 100; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //int[] numbers = new int[] { 1, 2, 3, 4, 5};
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Person[] persons = new Person[]
            //{
            //    new Person() { Id = 1, Name = "Hamada", Age = 20 },
            //    new Person() { Id = 2, Name = "Ahmed", Age = 25 },
            //    new Person() { Id = 3, Name = "Ali", Age = 30 }
            //};
            //foreach (Person person in persons)
            //{
            //    Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Age: {person.Age}");
            //}
            #endregion
            #region for - foreach
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 3)
            //        continue; // skip the current iteration
            //break; // exit the loop
            //return; // exit the method

            #endregion
            #endregion
            #region while - do while
            #region do while
            //int number ;
            //bool isparsed;
            //do
            //{
            //    Console.WriteLine("Please enter a even number");
            //    isparsed = int.TryParse(Console.ReadLine(), out number);
            //} while (!isparsed || number % 2==1);
            ////false==>!false==>true
            ////true==>!true==>false
            //Console.WriteLine(number); 
            #endregion
            #region while
            //int number;
            //bool isparsed;
            //Console.WriteLine("Please enter a number <=10");
            //isparsed = int.TryParse(Console.ReadLine(), out number);
            //if (isparsed)
            //{
            //    while (number <= 10)
            //    {
            //        Console.WriteLine(number );
            //        number++;
            //    }
            //}




            #endregion
            #endregion
            #region string
            //string name = "Hamada"; //syntax sugar for new string("Hamada");
            //string name = new string("mariam");
            //string name2 = "mariam";
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());
            //Console.WriteLine();
            //Console.WriteLine(name2);
            //Console.WriteLine(name2.GetHashCode());
            //name2 = "omar";
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());
            //Console.WriteLine();
            //Console.WriteLine(name2);
            //Console.WriteLine(name2.GetHashCode());

            //string name = "Hello";
            //Console.WriteLine(name);    
            //Console.WriteLine(name.GetHashCode());
            //name += "mariam";
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());

            //string name = "Hamada";
            ////static methods ==> class members methods ==> class
            ////Non-static methods ==> object members methods ==> instance

            //Console.WriteLine(name.Length); // 6
            //Console.WriteLine(name.ToUpper()); // "HAMADA"
            //Console.WriteLine(name.ToLower()); // "hamada"
            //Console.WriteLine(name.Contains("H")); // true
            //Console.WriteLine(name.Contains("h")); // false
            //Console.WriteLine(name.StartsWith("H")); // true
            //Console.WriteLine(name.EndsWith("a")); // true
            //Console.WriteLine(name.IndexOf("a")); // 5
            //Console.WriteLine(name.LastIndexOf("a")); // 5
            //Console.WriteLine(name.IndexOf("m")); // 2
            //Console.WriteLine(name.LastIndexOf("m")); // 2
            //Console.WriteLine(name.IndexOf("z")); // -1
            //Console.WriteLine(name.LastIndexOf("z")); // -1
            //Console.WriteLine(name.Substring(0, 3)); // "Ham"
            //Console.WriteLine(name.Substring(3)); // "ada"
            //Console.WriteLine(name.Replace("H", "h")); // "hamada"
            //Console.WriteLine(name.Replace("H", "h").Replace("a", "A")); // "hAmAdA"
            //Console.WriteLine(name.Trim()); // "Hamada" (removes leading and trailing whitespace)
            //Console.WriteLine(name.TrimStart()); // "Hamada" (removes leading whitespace)
            //Console.WriteLine(name.TrimEnd()); // "Hamada" (removes trailing whitespace)

            #endregion
            #region stringBuilder
            //is a built in class [reference data type ] and represente
            //mutable string
            //linkedlist of characters
            #region Examples
            //StringBuilder name;
            ////allocate 4 bytes
            ////name = "mariam" //invalid
            //name = new StringBuilder("mariam"); //valid
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());
            ////name+= " hamada"; //invalid
            //name.Append(" shindy"); //valid
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());


            //StringBuilder name1 = new StringBuilder("mohamed");
            //StringBuilder name2 = new StringBuilder("");
            //name2.Append("mohamed");
            //Console.WriteLine(name1);
            //Console.WriteLine(name1.GetHashCode());
            //Console.WriteLine(name2);
            //Console.WriteLine(name2.GetHashCode());
            //name1 =name2;
            //Console.WriteLine(name1);
            //Console.WriteLine(name1.GetHashCode());
            //Console.WriteLine(name2);
            //Console.WriteLine(name2.GetHashCode());
            #endregion
            #endregion
            #region StringBuilder Methods   
            //StringBuilder msg = new StringBuilder("Hamada");
            //Console.WriteLine(msg); // "Hamada"
            //Console.WriteLine(msg.GetHashCode()); // hash code of the string builder object
            //msg.Append(" Shindy"); // "Hamada Shindy"
            //                                      //int age = 20;
            //                                      //msg.appendformat("Hello {0}, you are {1} years old", name, age); // "Hello Hamada, you are 20 years old"
            //                                      //msg.clear(); // clears the StringBuilder

            ////Console.WriteLine(name.Length); // 6
            ////name.Append(" Shindy"); // "Hamada Shindy"
            ////name.AppendLine(" Ahmed"); // "Hamada Shindy\nAhmed"
            ////name.AppendJoin(", ", "Ali", "Omar", "Ahmed"); // "Hamada Shindy\nAhmed, Ali, Omar, Ahmed"
            #endregion
            #region 1D array
            //int[] numbers = new int[4]; // allocate 16 bytes of memory
            //int [] numbers = [1,2,4,5]; // allocate 16 bytes of memory
            //int[] numbers = new int[3] ; 
            //Array.Fill(numbers, 5); // initialize the array with default values
            //Console.WriteLine(numbers[0]); // 5
            //Console.WriteLine(numbers[1]); // 5
            //Console.WriteLine(numbers[2]); // 5

            //Array arr= Array.CreateInstance(typeof(int), 3); // allocate 12 bytes of memory
            //arr.SetValue(1, 0); // set the value of the first element to 1
            //arr.SetValue(2, 1); // set the value of the second element to 2
            //arr.SetValue(3, 2); // set the value of the third element to 3
            //Console.WriteLine(arr.GetValue(0)); // 1
            //Console.WriteLine(arr.GetValue(1)); // 2
            //Console.WriteLine(arr.GetValue(2)); // 3

            //object[] data = new object[3] {1, "mariam", true}; // allocate 24 bytes of memory
            //foreach (var item in data)
            //{
            //    Console.WriteLine(item); // 1, mariam, True
            //}



            //new
            //1] allocate required at heap 16 bytes of memory
            //2] initialize the array with default values
            //3] assign the reference of the array to the variable
            //4] call user defined constructor


            #endregion
            #region 2D array

            //int[,] marks = new int[3, 5]
            ////10 * 4bytes = 40 bytes
            //{
            //    { 100, 200, 300, 400, 500},
            //{ 600, 700, 800, 900, 1000 },
            //{ 1100, 1200, 1300, 1400, 1500}
            //}
            //;
            //for (int i = 0; i < marks.GetLength(0); i++)
            //{
            //    for (int j = 0; j < marks.GetLength(1); j++)
            //    {
            //        Console.Write(marks[i, j] + " ");
            //    }
            //    Console.WriteLine();
            }
            //marks[0,0] = 100;
            //marks[0, 1] = 200;
            //marks[0, 2] = 300;
            //marks[0, 3] = 400;
            //marks[0, 4] = 500;

            //Console.WriteLine(marks[0, 0]); // 100


            #endregion
        }
    }
}
