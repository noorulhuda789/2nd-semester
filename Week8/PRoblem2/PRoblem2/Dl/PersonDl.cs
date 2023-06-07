using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRoblem2.BL;
namespace PRoblem2.Dl
{
    class PersonDl
    {
        public static List<Person> people = new List<Person>();
        public static void addlist(Person p1)
        {
            people.Add(p1);
        }
    }
}
