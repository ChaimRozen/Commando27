using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando27
{
    enum Tools
    {
        hammer,
        pliers,
        knife
    }
    enum Status
    {
        standing,
        sitting,
        walk,
        hide
    }
    internal class Commando
    {
        private string name;
        private string codeName;
        private Tools tool;
        private Status status;

        public string Name
        {
            get { return name; }

            set { name = value; }
        }
        public string CodeName
        {
            get { return codeName; }
            set { codeName = value; }
        }

        public Commando(string name, string codeName)
        {
            name = name;
            codeName = codeName;
            status = Status.sitting;

        }
        public void Walk()
        {
            status = Status.walk;
            Console.WriteLine($"{codeName} is walking");
        }
        public void Hide()
        {
            status = Status.hide;
            Console.WriteLine($"{codeName} is hiding");
        }
        public void Attack()
        {
            Console.WriteLine($"commando named {codeName} is attack");
        }
    }
 
}
