using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface Add { }

    public interface Sum { }

    public interface IBaseAddition : Add, Sum
    {
        public int Invoke(string numbers, dynamic cal);
    }

    public class Addition : IBaseAddition
    {
        public int Invoke(string numbers, dynamic cal)
        {

            string[] str = numbers.Trim((char)',').Split((char)',');
            int len = str.Length;
            int result = 0;

            for (int i = 0; i < len; i++)
            {
                result += Int32.Parse(str[i].ToString());
            }

            return result;
        }
    }

    public interface Multiply { }

    public interface Mult { }

    public interface IBaseMultiplication : Multiply, Mult
    {
        public int Invoke(string numbers, dynamic cal);
    }


    public class Multiplication : IBaseMultiplication
    {
        public int _count { get; set; }

        public int Invoke(string numbers, dynamic cal)
        {

            string[] str = numbers.Trim((char)',').Split((char)',');
            int len = str.Length;
            int result = 1;

            for (int i = 0; i < len; i++)
            {
                result *= Int32.Parse(str[i].ToString());
            }

            return result;
        }
    }

    public class Count
    {
       
        public int Invoke(string operation, dynamic cal)
        {
            Type CallType = Assembly.Load("Calculator").GetExportedTypes().Where((t) =>
            {
                return
                     (!t.IsInterface && !t.IsAbstract)
                     &&
                     (
                        Type.GetType($"Calculator.{operation}", false, true).IsAssignableFrom(t)
                         ||
                        (Type.GetType($"Calculator.{operation}", false, true).IsClass && Type.GetType($"Calculator.{operation}", false, true).IsAssignableFrom(t))
                     );
            }).FirstOrDefault();

            return cal.listObject[CallType].Item2;
        }
    }


    public class Calculator
    {
        public IDictionary<Type, Tuple<object, int>> listObject = new Dictionary<Type, Tuple<object, int>>();

        public void CallMe(string[] input)
        {
            Type CallType = Assembly.Load("Calculator").GetExportedTypes().Where((t) =>
            {
                return
                     (!t.IsInterface && !t.IsAbstract)
                     &&
                     (
                        Type.GetType($"Calculator.{input[0]}", false, true).IsAssignableFrom(t)
                         ||
                        (Type.GetType($"Calculator.{input[0]}", false, true).IsClass && Type.GetType($"Calculator.{input[0]}", false, true).IsAssignableFrom(t))
                     );
            }).FirstOrDefault();

            if (!listObject.Keys.Contains(CallType))
            {
                object calculator = Activator.CreateInstance(CallType);
                listObject.Add(CallType, new Tuple<object, int>(calculator, 1));
            }
            else
            {
                var obj = listObject[CallType];
                listObject.Remove(CallType);
                listObject.Add(CallType, new Tuple<object, int>(obj.Item1, obj.Item2 + 1));
            }

            MethodInfo function = listObject[CallType].Item1.GetType().GetMethod("Invoke");
            var result = function.Invoke(listObject[CallType].Item1, new object[] { input[1], this });
            Console.WriteLine(result);
        }

    }

}
