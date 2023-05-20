using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6.BL
{
    class Student
    {
        public string name;
        public string age;
        public float fsc;
        public float ecat;
        public int prefernce;
        public Degree registeredDegree;
        public float merits;
        public List<Degree> prefernces = new List<Degree>();
        public List<Subject> subjects = new List<Subject>();
        public Student(string name, string age, float fsc, float ecat, List<Degree> prefernces)
        {
            this.name = name;
            this.age = age;
            this.ecat = ecat;
            this.fsc = fsc;
            this.prefernces = prefernces;
            subjects = new List<Subject>();
        }
        public void merit()
        {
           this. merits = (((fsc / 1100) * 60) + ((ecat / 400) * 40));
        }
        public float fee()
        {
            float fees = 0;
            foreach (var subject in subjects)
            {
                fees += (subject.fee) * (subject.credithours);
            }
            return fees;
        }
        public int credithour()
        {
            int count = 0;
            foreach(Subject sub in  subjects)
            {
                count = count + sub.credithours;
            }
            return count;

        }
        public bool registerofsubjects(Subject s)

        {
            int chu = credithour();
            if(registeredDegree != null && registeredDegree.issubjectexit(s) && chu+s.credithours<=9)
            {
                subjects.Add(s);
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
