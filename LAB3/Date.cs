using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class Date
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }


        public Date(int ayear, int amonth, int aday)
        {
            Year = ayear;
            Month = amonth;
            Day = aday;
        }

        public string TellAboutSelf()
        {
            return $"The year is is: {Year}\n The Month is: {Month}\n The Day is: {Day}";
        }

        public void AddDays(int howMany)
        {
            int total = Day + howMany;
            Year = Year+ total / 365;
            Month =(total % 365) / 30;
            Day = (total % 365) % 30;
            }
        }
    }
