using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Agency
{
    class Complaints
    {

       private String complaint;

        public void MakeComplaint(string complaint)
        {
            this.complaint = complaint;
        }

        public String GetInfo()
        {
            return this.complaint;
        }

    }
}
