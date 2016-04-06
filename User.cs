using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class User
    {
        private int userType;

        public User(int type)
        {
            userType = type;
        }
        public int getType()
        {
            //Leeke
            return userType;
        }
    }
}
