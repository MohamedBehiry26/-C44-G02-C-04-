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
        }
    }
}
