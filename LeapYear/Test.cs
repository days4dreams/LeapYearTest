using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    public class Test
    {
        bool LeapStatus = true;
        public bool CalculateLeapStatus(int givenYear)
        {

            if (givenYear % 4 == 0)
            {
                if (givenYear % 100 == 0)
                {
                    if (givenYear % 400 == 0)
                    {
                        LeapStatus = true;
                    }
                    else
                    {
                        LeapStatus = false;
                    }
                }
                else
                {
                    LeapStatus = true;
                }
            }

            else
            {
                LeapStatus = false;
            }

            return LeapStatus;
        }
    }
}
