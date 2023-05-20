using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01.BL
{
    public class MenuItem
    {
        public string Name;
        public string Type;
        public float Price;

        public MenuItem(string Name, string Type, float Price)
        {
            this.Name = Name;
            this.Type = Type;
            this.Price = Price;
        }
    }
}
