using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Commando27
{
    internal class Weapon
    {
        private string name;
        private string manufacturer;
        private int bullets_number;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Manufacturer
        { 
            get { return manufacturer; } 
            set { manufacturer = value; } 
        }
        public int BulletsNumber
        {
            get { return bullets_number; }
            set { bullets_number = value; }
        }
        public void Shot()
        {
            if (BulletsNumber > 0)
            {
                BulletsNumber--;
                Console.WriteLine("1 bullet shot");
            }
            else
            {
                Console.WriteLine("no bullets");
            }
        }
    }
}
