using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uams.BL
{
    class Student
    {
        public string name;
        public string age;
        public float fsc;
        public float ecat;
        public int prefernce;
        public Degree registeredDegree;
        public float meritis;
        public List<Degree> prefernces = new List<Degree>();
        public List<Subject> subjects = new List<Subject>();
        public Student(string name, string age, float fsc, float ecat, int prefernce)
        {
            this.name = name;
            this.age = age;
            this.ecat = ecat;
            this.fsc = fsc;
            this.prefernce = prefernce;
            registeredDegree = null;
        }
        public void addstudent(List<Student> students, Student s)
        {
            students.Add(s);
        }
        public void prefernceadd(Degree s)
        {
            prefernces.Add(s);
        }
        public Student()
            {

            }
        public void merit()
        {
            meritis = (((fsc / 1100) * 60) + ((ecat / 400) * 40));
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
    }

    
}
