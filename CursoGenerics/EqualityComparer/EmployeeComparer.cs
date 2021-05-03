using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoGenerics.EqualityComparer
{
    public class EmployeeComparer : IEqualityComparer<Employee>, IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return String.Compare(x.Name, y.Name);
        }

        public bool Equals(Employee x, Employee y)
        {
            return String.Equals(x.Name, y.Name);
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
