using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using TypeForwardedToAttribute_First;

/*Need to refer using System.Runtime.CompilerServices*/
[assembly: TypeForwardedTo(typeof(HouseKeeping))]
namespace TypeForwardedToAttribute_First
{
    /* This HouseKeeping class is moved to TypeForwardedToAttribute_Second*/
    //public class HouseKeeping
    //{
    //    public void DisplayHouseKeeping()
    //    {
    //        Console.WriteLine("HouseKeeping Class");
    //    }
    //}


    /// <summary>
    /// This is a Manager Class
    /// </summary>
    public class Manager : Employee
    {
        /// <summary>
        /// This Method will display details about Manager
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Manager Class");
        }

    }

    public class Clerk : Employee
    {
        /// <summary>
        /// This Method will display details about Clerk
        /// </summary>

        public void DisplayClerk()
        {
            Console.WriteLine("Clerk Class");
        }

    }

    public class Employee
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trainee Class Will be Moved");

        }
        /// <summary>
        /// This is a main Method will display details about Manager,Clerk,Trainee
        /// </summary>

        public static void Display()
        {




        }
    }
}