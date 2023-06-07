using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRoblem2.BL
{
    class Staff:Person
    {
        private string school;
        private int pay;
        public Staff(string name, string address,string school,int pay) : base(name, address)
        {
            this.school = school;
            this.pay = pay;

        }
        public string getschool()
        { return school;
        }
        public void setschool(string school)
        {
            this.school = school;
        }
        public int getpay()
        {
            return pay;

        }
        public void setpay(int pay)
        {
            this.pay = pay;
        }
        public override string tostring()
        {
            return "Staff" + " " + base.name + " " + base.address + " " + school + " " + pay;
        }


    }
}
