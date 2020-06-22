using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Agency
{
    class Users
    {


        String username;
        String password;

        public void MakeUser(String username, String password)
        {
            this.username = username;
            this.password = password;
        }

        public String GetUsername()
        {
            return this.username;
        }

        public String GetPassword()
        {
            return this.password;
        }
    }
}
//  

