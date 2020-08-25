using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_Race_Rajpal
{
    public class RajpalRunningClass
    {
        //generate the random numbers
        Random rd = new Random();
        public int moving()//moving steps
        {
            return rd.Next(1, 35);
        }
    }
}
