using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class TestFunc
    {
        public static void CallMe()
        {
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(2));

            Func<string, string, string> concat = (x, y) => x + "  " + y;
            Console.WriteLine(concat("yashad", "singh"));
            Action<string, int, double> foo = (a, b, c) => { Console.WriteLine(a); Console.WriteLine(b); Console.WriteLine(c); };
            foo("hello", 1, 1);

            Func<int, int, int> add = (x, y) => { return x + y; };
            Console.WriteLine(add(1, 3));

        }

    }

    class Movie
    {

        private string _name;
        public string name
        {
            get
            {
                Console.WriteLine($"Fetching movie name {_name}");
                return _name;
            }
            set
            {
                _name = value;
            }
        }

    }

    class LinqQueries
    {

        public static void CallMe()
        {

            var query = FuncExtention.Random().Where(x => x > 0.5).Take(10).ToList<double>().OrderByDescending(x => x);

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            var listItems = new List<Movie>() { new Movie(){name="Iron Man" },
                                                    new Movie(){name="Thor" },
                                                    new Movie(){name="Captain America" },
                                                    new Movie(){name="Hukl" },
                                                    new Movie(){name="Falcon" }
                                                  };

            var result = listItems.Filter(x => x.name.Contains("o"));

            foreach (Movie item in result)
            {
                Console.WriteLine(item.name);
            }

        }


    }

    public static class FuncExtention
    {

        public static IEnumerable<double> Random()
        {

            var random = new Random();

            while (true)
            {
                yield return random.NextDouble();
            }

        }


        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {

            var result = new List<T>();

            foreach (T item in source)
            {

                if (predicate(item))
                {
                    //result.Add(item);
                    yield return item;
                }
            }

        }

    }

}
