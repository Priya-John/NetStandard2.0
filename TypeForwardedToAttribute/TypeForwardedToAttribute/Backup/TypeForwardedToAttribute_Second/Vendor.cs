using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/*The name space is modified from TypeForwardedToAttribute_First to TypeForwardedToAttribute_Second as 
 this is must for TypeForwarding to attribute as the  
 *Rule says:"The original type and the forwarded type must be in a same namespace."*/
namespace TypeForwardedToAttribute_First
{


    public class HouseKeeping
    {
        public void DisplayHouseKeeping()
        {
            Console.WriteLine("HouseKeeping Class from Vendor");
        }
    }

    /// <summary>
    /// Main Vendor Class
    /// </summary>
    public class Vendor
    {
        static void Main(string[] args)
        {
        }
    }
}
