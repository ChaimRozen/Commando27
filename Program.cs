using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando commando1 = new Commando("soldier", "ab56");
            Console.WriteLine(commando1.CodeName);
            Console.Read();
        }
    }
}
