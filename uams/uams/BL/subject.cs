using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uams.BL
{
    class Subject
    {
      
        public Subject(string name, int code, int fee, int credithours)
        {
            this.name = name;
            this.code = code;
            this.fee = fee;
            this.credithours = credithours;
        }
        public string name;
        public int code;
        public int fee;
        public int credithours;
        public int credithour()
        {
            return credithours;

        }

        public Subject()
        {
        }

    }
}
