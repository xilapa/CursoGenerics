using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoGenerics.GenericConstraints.Models
{
    public class Employee2 : Person
    {
        public int Id { get; set; }

        public virtual void DoWork()
        {
            Console.WriteLine("Doing real work");
        }
    }
}
