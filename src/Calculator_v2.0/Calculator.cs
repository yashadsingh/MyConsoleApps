using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Calculator_v2_0
{

    #region Addition

    public interface ICommand
    {
        public int Invoke(string param, IServiceProvider? commands);

        public Boolean SearchByAlias(string alias);

        public int GetCount();

    }

    public class Addition : ICommand
    {
        private readonly IEnumerable<string> _aliases = new List<string>() { "add", "addition", "sum" };

        private int _count { get; set; }

        public int GetCount()
        {
            return _count;
        }

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

        public bool SearchByAlias(string alias)
        {
            return _aliases.Any(x => x.Equals(alias, StringComparison.OrdinalIgnoreCase));
        }
    }

    public class Multiplication : ICommand
    {
        private readonly IEnumerable<string> _aliases = new List<string>() { "multiply" };

        private int _count { get; set; }

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

        public bool SearchByAlias(string alias)
        {
            return _aliases.Any(x => x.Equals(alias, StringComparison.OrdinalIgnoreCase));
        }

        public int GetCount()
        {
            return _count;
        }
    }

    #endregion

    #region Multiply

    #endregion

    #region Count

    public class Count : ICommand
    {
        private int _count { get; set; }

        private readonly IEnumerable<string> _aliases = new List<string>() { "count" };

        public int Invoke(string operation, IServiceProvider? commands)
        {

            var serializer = commands.GetServices<ICommand>().Where(o =>
            {
                return o.SearchByAlias(operation);

            }).FirstOrDefault();

            _count++;

            return serializer.GetCount();
        }

        public int GetCount()
        {
            return _count;
        }

        public bool SearchByAlias(string alias)
        {
            return _aliases.Any(x => x.Equals(alias, StringComparison.OrdinalIgnoreCase));
        }
    }

    #endregion

}
