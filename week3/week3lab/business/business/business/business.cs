using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.business
{

    class Admin
    {
        public int count = 0;
        public int countforhotel = 0;
        public int row = 0;
        public int column = 0;
        public string hotelname;
        public int hotelprice;
        public Admin(string hotelname,int hotelprice)
        {
            this.hotelname = hotelname;
            this.hotelprice = hotelprice;
        }
        
    }
        class signin
        {
            public string name;
            public string password;
        public signin(string name,string password)

        {
            this.name = name;
            this.password = password;
        }
        }
        


        
}

