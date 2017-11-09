using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDataProtection();
            var services = serviceCollection.BuildServiceProvider();

            // create an instance of MyClass using the service provider
            var instance = ActivatorUtilities.CreateInstance<NetStandardEncryption.Class1>(services);

            var x = instance.GetStrValue();

            Console.WriteLine("\n NetStandard protected Payload:" + x.protectedPayload);
            Console.WriteLine("\n NetStandard uprotected Payload:" + x.unprotectedPayload);
            Console.ReadLine();

           
        }
    }
}
