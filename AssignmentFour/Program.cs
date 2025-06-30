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
            Console.WriteLine("Please enter your budget");
            int.TryParse(Console.ReadLine(), out int budget);
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
        }
    }
}
