using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRoblem2.BL
{
    class Student : Person
     {
        private string program;
        private int year;
        private double fee;
        public Student(string name,string address,int year,double fee,string program):base(name,address)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }
        public string getprogram()
        {
            return program;
        }
        public void setfee(double fee)
        {
            this.fee = fee;
        }
        public double getfee()
        {
            return fee;
        }
        public void setprogram(string program)
        {
            this.program = program;
        }
        public int getyear()
        {
            return year;
        }
        public void setyear(int year)
        {
            this.year= year;
        }
        public override string tostring()
        {
            return "Student" + " " + base.name +" "+ base.address + " " + program + " " + fee + " " + year;
        }
    }
}
