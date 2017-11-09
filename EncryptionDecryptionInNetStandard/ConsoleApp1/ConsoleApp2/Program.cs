using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            FrameworkDeEncryption.Class1 cls = new FrameworkDeEncryption.Class1();

            var x1 = cls.GetStrValue();

            Console.WriteLine("\n Framework protected Payload:" + x1.protectedPayload);
            Console.WriteLine("\n Framework uprotected Payload:" + x1.unprotectedPayload);
            Console.ReadLine();
        }
    }
}
