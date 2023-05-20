using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6.BL
{
    class Degree
    {

        public string degreetitle;
        public float degreeduration;
        public int seats;
        public List<Subject> subjects = new List<Subject>();

        public Degree(string degreetitle, float degreeduartion, int seats)
        {
            this.degreetitle = degreetitle;
            this.degreeduration = degreeduartion;
            this.seats = seats;

        }
        public bool issubjectexit(Subject sub)
        {
            foreach (Subject s in subjects)
            {
                if (s.code == sub.code)
                {
                    return true;

                }
            }
            return false;
        }
        public int calculatorcredithour()
        {
            int count = 0;
            for (int i = 0; i < subjects.Count; i++)
            {
                count = count + subjects[i].credithours;
            }
            return count;
        }
        public bool Addsubject(Subject s)
        {
            int ch = calculatorcredithour();
            if (ch + s.credithours <= 20)
            {
                subjects.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Degree(){

    }
}
}
