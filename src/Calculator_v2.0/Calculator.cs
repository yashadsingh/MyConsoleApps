using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Calculator_v2_0
{

    #region Addition

    /// <summary>
    /// ICommand
    /// Date: 08/14/2021
    /// </summary>
    public interface ICommand
    {
        public int Invoke(string param, IServiceProvider? commands);

        public Boolean SearchByAlias(string alias);

        public int GetCount();

    }

    /// <summary>
    /// Addition is a Command
    /// Date: 08/14/2021
    /// </summary>
    public class Addition : ICommand
    {
        private readonly IEnumerable<string> _aliases = new List<string>() { "add", "addition", "sum" };

        private int _count { get; set; }

        /// <summary>
        /// Get total count
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            return _count;
        }

        /// <summary>
        /// Invoke Addition operation
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="commands"></param>
        /// <returns></returns>
        public int Invoke(string numbers, IServiceProvider? commands)
        {

            string[] str = numbers.Trim((char)',').Split((char)',');
            int len = str.Length;
            int result = 0;

            for (int i = 0; i < len; i++)
            {
                result += Int32.Parse(str[i].ToString());
            }
            _count++;
            return result;
        }

        /// <summary>
        /// Search By Alias
        /// </summary>
        /// <param name="alias"></param>
        /// <returns></returns>
        public bool SearchByAlias(string alias)
        {
            return _aliases.Any(x => x.Equals(alias, StringComparison.OrdinalIgnoreCase));
        }
    }

    /// <summary>
    /// Multiplication is a Command
    /// Date: 08/14/2021
    /// </summary>
    public class Multiplication : ICommand
    {
        private readonly IEnumerable<string> _aliases = new List<string>() { "multiply" };

        private int _count { get; set; }

        /// <summary>
        /// Invoke Multiplication operation
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="commands"></param>
        /// <returns></returns>
        public int Invoke(string numbers, IServiceProvider? commands)
        {

            string[] str = numbers.Trim((char)',').Split((char)',');
            int len = str.Length;
            int result = 1;

            for (int i = 0; i < len; i++)
            {
                result *= Int32.Parse(str[i].ToString());
            }
            _count++;
            return result;
        }

        /// <summary>
        /// Search By Alias
        /// </summary>
        /// <param name="alias"></param>
        /// <returns></returns>
        public bool SearchByAlias(string alias)
        {
            return _aliases.Any(x => x.Equals(alias, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Get count
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            return _count;
        }
    }

    #endregion

    #region Multiply

    #endregion

    #region Count

    /// <summary>
    /// Count is a Command
    /// Date: 08/14/2021
    /// </summary>
    public class Count : ICommand
    {
        private int _count { get; set; }

        private readonly IEnumerable<string> _aliases = new List<string>() { "count" };

        /// <summary>
        /// Invoke count operation
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="commands"></param>
        /// <returns></returns>
        public int Invoke(string operation, IServiceProvider? commands)
        {

            var serializer = commands.GetServices<ICommand>().Where(o =>
            {
                return o.SearchByAlias(operation);

            }).FirstOrDefault();

            _count++;

            return serializer.GetCount();
        }

        /// <summary>
        /// Get total count  
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            return _count;
        }

        /// <summary>
        /// Search By Alias
        /// </summary>
        /// <param name="alias"></param>
        /// <returns></returns>
        public bool SearchByAlias(string alias)
        {
            return _aliases.Any(x => x.Equals(alias, StringComparison.OrdinalIgnoreCase));
        }
    }

    #endregion

}
