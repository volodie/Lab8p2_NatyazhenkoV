using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTitle
{
    public class Director : IJobTitlePrintable
    {
        public void PrintJobTitile(string jobTittle)
        {
            Console.WriteLine("Ttitle of job is: " + jobTittle);
        }
    }
}
