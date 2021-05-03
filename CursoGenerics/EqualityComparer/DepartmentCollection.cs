using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoGenerics.EqualityComparer
{
    public class DepartmentCollection : Dictionary<string, SortedSet<Employee>>
    {
        public DepartmentCollection Add(string department, Employee employee)
        {
            if(!ContainsKey(department))
            {
                Add(department, new SortedSet<Employee>(new EmployeeComparer()));
            }
            this[department].Add(employee);
            return this;
        }
    }
}
