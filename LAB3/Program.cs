using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class Program
    {
        static void Main(string[] args)
        {
            Date aDate = new Date(2019, 9, 20);
            aDate.AddDays(1000000);
            Console.WriteLine(aDate.TellAboutSelf()); 
        }
    }
}
