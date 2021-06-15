using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19
{
    class CovidMain
    {
        
        static void Main(string [] args)
        {
            CovidMenuManager covidMenu = new CovidMenuManager();

            covidMenu.MainLoop();

        }
    }
}
