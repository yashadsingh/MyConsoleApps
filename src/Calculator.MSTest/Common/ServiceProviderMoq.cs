using Calculator_v2_0;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace Calculator.MSTest.Mock
{
    /// <summary>
    /// ServiceProviderMoq
    /// </summary>
    public class ServiceProviderMoq
    {

        /// <summary>
        /// Common code being used 
        /// in several Tests
        /// </summary>
        /// <returns></returns>
        public static IServiceProvider GetServiceProvider()
        {
            IServiceCollection container = new ServiceCollection();
            container.TryAddEnumerable(ServiceDescriptor.Singleton<ICommand, Multiplication>());
            container.TryAddEnumerable(ServiceDescriptor.Singleton<ICommand, Addition>());
            container.TryAddEnumerable(ServiceDescriptor.Singleton<ICommand, Count>());

            return container.BuildServiceProvider();
        }
    }
}
