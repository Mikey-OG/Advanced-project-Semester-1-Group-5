using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Agency
{
    class Houserules
    {
        private String rule;

        public void makeHouserule(String rule)
        {
            this.rule = rule;
        }

        public String GetInfo()
        {
            String Info;
            Info = this.rule;
            return Info;
        }
    }
}

