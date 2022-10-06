using System;

using Microsoft.Extensions.DependencyInjection;


namespace D8S.E0001
{
    class Program
    {
        static void Main()
        {
            //Program.CreateEmptyProvider();
            //Program.TryGetNonExistentService();
            Program.TryGetNonExistentServiceA();
        }

        static void TryGetServiceA()
        {
            ServiceCollection serviceCollection = new();

            serviceCollection.AddTransient()

            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
        }

        static void TryGetNonExistentServiceA()
        {
            ServiceCollection serviceCollection = new();

            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            Type typeOfClassA = typeof(ClassA);

            object classAInstance_AsObject = serviceProvider.GetService(typeOfClassA);

            ClassA classAInstance = (ClassA)classAInstance_AsObject;

            bool serviceIsNull = classAInstance is null;

            // Output: Service is null? True.
            Console.WriteLine($"Service is null? {serviceIsNull}");
        }

        static void TryGetNonExistentService()
        {
            ServiceCollection serviceCollection = new();

            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            Type serviceType = typeof(Object);

            object service = serviceProvider.GetService(serviceType);

            bool serviceIsNull = service is null;

            // Output: Service is null? True.
            Console.WriteLine($"Service is null? {serviceIsNull}");
        }

        static void CreateEmptyProvider()
        {
            ServiceCollection serviceCollection = new();

            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            // Great! Now what?
        }
    }
}