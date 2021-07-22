using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class IQueriableTest
    {
        public class Department {
            public int depId { get; set; }
            public string DepName { get; set; }

            public ISet<Employee> employees { get; private set; }

            public Department()
            {
                employees = new HashSet<Employee>();
            }
        }
        public class Employee {

            public int Id { get; set; }
            public string Name { get; set; }

            public Department Dept { get; set; }
        }

        public static void CallMe() {

            var emp = new List<Employee>();
            var dept = new List<Department>();

            //emp.Where(x=> x.Id == 9).In
       

        }
    }
}
