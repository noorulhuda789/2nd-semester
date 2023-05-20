using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6.BL
{
    class Subject
    {
        public Subject(string code, string name, int fee, int credithours)
        {
            this.name = name;
            this.code = code;
            this.fee = fee;
            this.credithours = credithours;
            
        }
        public string name;
        public string code;
        public int fee;
        public int credithours;
    }
}
