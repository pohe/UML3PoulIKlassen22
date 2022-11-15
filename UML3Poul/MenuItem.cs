using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3Poul
{
    public class MenuItem : IMenuItem
    {

        private int _number; 
        public int Number { get
            {
                return _number;
            }
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public MenuType Type { get; set; }
        public bool IsVegan { get; set; }
        public bool IsOrganic { get; set; }

        public MenuItem(int number, string name, string description, double price, MenuType type)
        {
            _number = number;
            Name = name;
            Description = description;
            Price = price;
            Type = type;
            IsVegan = true;
            IsOrganic = true;
        }
        public virtual string PrintInfo()
        {
            return $"Number {Number} Name  {Name} Description {Description} Price {Price} Menutype {Type} IsVegan {IsVegan}  IsOrganic {IsOrganic}";
        }

    }
}
