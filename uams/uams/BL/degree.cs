using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uams.BL
{
    class Degree
    {

        public string degreetitle;
         public  int degreeduration;
        public int seats;
        public List<Subject> subjects = new List<Subject>();
        
        public Degree(string degreetitle,int degreeduartion, int seats)
        {
            this.degreetitle = degreetitle;
            this.degreeduration = degreeduartion;
            this.seats = seats;

        }
        public void addsubject(Subject s)
        {
            subjects.Add(s);
        }
        public void adddegree(List<Degree>degree,Degree s)
        {
            degree.Add(s);
        }
        public Degree()
        {

        }


    }
}
