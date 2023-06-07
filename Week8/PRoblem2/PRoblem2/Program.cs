using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRoblem2.BL;
using PRoblem2.Dl;
namespace PRoblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("noor", "12asdju", 1987, 90.0, "computerscience");
            Student s1 = new Student("rameen", "12asdju", 1987, 90.0, "computerscience");
            Staff s2 = new Staff("eisha", "12asdju", "wapda", 90);
            Staff s3 = new Staff("fatima", "12asdju", "wapda", 90);
            PersonDl.addlist(s);
            PersonDl.addlist(s1);
            PersonDl.addlist(s2);
            PersonDl.addlist(s3);
            foreach (Person p in PersonDl.people)
            {
                Console.WriteLine(p.tostring());
            }
            Console.ReadKey();
        }
    }
}
