using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3Poul
{
    public class Pizza :MenuItem
    {

        public bool DeepPan { get; set; }

        public Pizza(bool deepPan, int number, string name, string description, double price, MenuType type) : base(number, name, description, price, type)
        {
            DeepPan = deepPan;
        }

        public override string PrintInfo()
        {
            return base.PrintInfo();
        }
    }
}
