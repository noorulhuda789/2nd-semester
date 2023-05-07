using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5lab.multipleclass
{
    class Student
    {
        public string name;
        public int rollnumber;
        public float cgpa;
        public int matricmarks;
        public double fscmarks;
        public double ecatmarks;
        public string hometwon;
        public bool isdayscholar;
        public bool istakingscholarship;
        
        public Student(string name,int matric,double fsc,int rollnumber,double ecat,float cgpa,string hometwon,bool isdayscholar, bool istakingscholarship)
        {
            this.name = name;
            this.fscmarks = fsc;
            this.matricmarks = matric;
            this.ecatmarks = ecat;
            this.cgpa = cgpa;
            this.hometwon = hometwon;
            this.isdayscholar = isdayscholar;
            this.rollnumber = rollnumber;
            this.istakingscholarship = istakingscholarship;
        }
        public double merit()

        {
             double meritis;
          meritis = ((fscmarks/1100) * 60) + ((ecatmarks/400) * 40);
            return meritis;

        }
        public bool scholarship(double meritis)
        {
            bool availing;
            if(meritis>80 && isdayscholar==false && istakingscholarship==false)
            {
                availing = true;
            }
            else
            {
                availing = false;
            }
            return availing;
        }

    }
    
}
