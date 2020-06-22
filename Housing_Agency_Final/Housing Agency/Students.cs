using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Agency
{
    class Students
    {
     
        
            private string name;
            private string email;
            private int PCN;

            public void SetName(string newName)
            {
                if (newName != "")
                { this.name = newName; }

            }
            public string GetInfo()
            {
                return this.name + "with PCN" + this.PCN.ToString();
            }
        }
    }

