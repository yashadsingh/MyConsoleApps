using Calculator.MSTest.Mock;
using Calculator_v2_0;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System.Linq;

namespace Calculator.MSTest
{
    /// <summary>
    /// CalculatorTest
    /// Date: 08/14/2021
    /// </summary>
    public class CalculatorTest
    {
        [Test]
        public void Calculator_Add_Test()
        {

            var serviceProvider = ServiceProviderMoq.GetServiceProvider();
            var serializer = serviceProvider.GetServices<ICommand>().Where(operation =>
            {
                return operation.SearchByAlias("add");
            }).FirstOrDefault();

            var result = serializer.Invoke("2,8", serviceProvider); // 2 + 8 = 10

            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Calculator_Add_Count()
        {

            var serviceProvider = ServiceProviderMoq.GetServiceProvider();
            var serializer = serviceProvider.GetServices<ICommand>().Where(operation =>
            {
                return operation.SearchByAlias("add");
            }).FirstOrDefault();

            serializer.Invoke("2,8", serviceProvider); // First Invoke
            serializer.Invoke("1,1", serviceProvider); // Second Invoke

            serializer = serviceProvider.GetServices<ICommand>().Where(operation =>
            {
                return operation.SearchByAlias("count"); 
            }).FirstOrDefault();

            var result = serializer.Invoke("sum", serviceProvider); // sum = add : Invoked 2 times

            Assert.That(result, Is.EqualTo(2));

        }

        [Test]
        public void Calculator_Multiply_Test()
        {

            var serviceProvider = ServiceProviderMoq.GetServiceProvider();
            var serializer = serviceProvider.GetServices<ICommand>().Where(operation =>
            {
                return operation.SearchByAlias("multiply");
            }).FirstOrDefault();

            var result = serializer.Invoke("5,0,1,2", serviceProvider); // 5*0*1*2 = 0

            Assert.That(result, Is.EqualTo(0));

        }

        [Test]
        public void Calculator_Count_Test()
        {

            var serviceProvider = ServiceProviderMoq.GetServiceProvider();
            var serializer = serviceProvider.GetServices<ICommand>().Where(operation =>
            {
                return operation.SearchByAlias("multiply");
            }).FirstOrDefault();

            serializer.Invoke("5,2", serviceProvider); // multiply invoked

            serializer = serviceProvider.GetServices<ICommand>().Where(operation =>
            {
                return operation.SearchByAlias("count");
            }).FirstOrDefault();

            serializer.Invoke("multiply", serviceProvider); // count: first invoke against multiplication

            var result = serializer.Invoke("count", serviceProvider); // count: second invoke against count itself

            Assert.That(result, Is.EqualTo(2));

        }
    }
}
