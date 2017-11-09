/*The purpose of this Source code is to make the Concept of TypeForwardedToAttribute crystal clear 
     SHORT DESCRIPTION -The scenario is you have an application which have a Project which  have the Details
     * of an Employee like Manager ,Clerk and House keeping ,and you have successfully deployed the application ,but some time down the 
     * line it was ralized that the HouseKeeping Class is BestSuited Under Vendor Category which is in another project(dll) 
     * then we can make the changes in the Code of Employeee which is in another project(dll) to the Vendor Class
     * and just use  the TypeForwardedToAttribute to avoid the re-building of an applicatioon and re-deploying it
     * we just build the respective project and use there dll except the main hosting application and the trick works 
 
Thumb Rool -Only use is when you have some legacy application (no source available, or cannot recompile for any other reason) 
 * referencing the type T1 originally located in A1 and for whatever reason you need to move the type out from that
 * assembly.Then you can use the concept of TypeForwardedToAttribute and you'll have your type happily moved out 
 * of A1 to A2, legacy binary still referencing the A1, but using type T1 from A2.At least that's the reason for 
 * the attribute from my understanding
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TypeForwardedToAttribute_First;
/*VERY IMPORTANT NOTE: Don’t build the TypeForwardedToAttribute project again here elsewhere you will 
 * get a compiler error because of following rule.
 * RULE: Forwarded types can’t be referenced.*/
namespace TypeForwardedToAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please understand the Type Forwarding Concept");
            Clerk objClerk = new Clerk();
            Manager objManager = new Manager();
            HouseKeeping objHouseKeeping = new HouseKeeping();


            objClerk.DisplayClerk();
            objManager.Display();
            objHouseKeeping.DisplayHouseKeeping();
            Employee.Display();
            Console.ReadLine();
        }
    }
}
