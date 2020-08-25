using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_Race_Rajpal
{
    public class RajpalGuyClass
    {
        public int budgetSet(String data, int Budget, int winnerDog)
        {

            String[] filter = data.Split(' ');

            if (winnerDog == Convert.ToInt32(filter[2]))
            {
                return Budget + Convert.ToInt32(filter[5]);
            }
            else
            {
                return Budget - Convert.ToInt32(filter[5]);
            }
        }
    }
}
