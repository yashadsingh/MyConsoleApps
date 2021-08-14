using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Linq;

namespace Calculator_v2_0
{
    /// <summary>
    /// Entry point
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main
        /// Date: 08/14/2021
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Adding DI container for different implementations of different commands
            IServiceCollection container = new ServiceCollection();
            container.TryAddEnumerable(ServiceDescriptor.Singleton<ICommand, Multiplication>());
            container.TryAddEnumerable(ServiceDescriptor.Singleton<ICommand, Addition>());
            container.TryAddEnumerable(ServiceDescriptor.Singleton<ICommand, Count>());

            IServiceProvider serviceProvider = container.BuildServiceProvider();

            Console.WriteLine("Enter a command");
            while (true)
            {
                Calculator(serviceProvider);
            }
        }

        /// <summary>
        /// Calculate 
        /// Date: 08/14/2021
        /// </summary>
        /// <param name="serviceProvider"></param>
        public static void Calculator(IServiceProvider serviceProvider)
        {
            string[] input = Console.ReadLine().Split(" ");

            var serializer = serviceProvider.GetServices<ICommand>().Where(operation =>
            {
                return operation.SearchByAlias(input[0]);
            }).FirstOrDefault();

            if (serializer == null)
                Console.WriteLine("Invalid alias");
            else
                Console.WriteLine(serializer.Invoke(input[1], serviceProvider));
        }

    }
}
