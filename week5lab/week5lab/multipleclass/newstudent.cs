using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5lab.multipleclass
{
    class newstudent
    {
        public string name;
        public int age;
        public float ecat;
        public float fsc;
        public float merit;
        List<Degree> prefernce = new List<Degree>();
        public newstudent(string name,int age,float fsc,float ecat)
        {
            this.name = name;
            this.age = age;
            this.ecat = ecat;
            this.fsc = fsc;
        }
        public void meritofstudent()
        {
           merit= ((fsc / 1100) * 60) + ((ecat / 400) * 40);
        }
    }
}
