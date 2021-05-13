using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoGenerics.GenericConstraints.Models
{
    public class Manager : Employee2, IEntity
    {
        public override void DoWork()
        {
            Console.WriteLine("Create a meeting");
        }

        public bool IsValid()
        {
            return true;
        }
    }
}
