using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Linq;

namespace Calculator_v2_0
{
    class Program
    {
        static void Main(string[] args)
        {

            IServiceCollection container = new ServiceCollection();
            container.TryAddEnumerable(ServiceDescriptor.Singleton<ICommand, Multiplication>());
            container.TryAddEnumerable(ServiceDescriptor.Singleton<ICommand, Addition>());
            container.TryAddEnumerable(ServiceDescriptor.Singleton<ICommand, Count>());

            IServiceProvider serviceProvider = container.BuildServiceProvider();

            Console.WriteLine("Enter a command");
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");

                var serializer = serviceProvider.GetServices<ICommand>().Where(operation =>
                {
                    return operation.SearchByAlias(input[0]);
                }).FirstOrDefault();

                Console.WriteLine(serializer.Invoke(input[1], serviceProvider));
            }
        }
    }
}
