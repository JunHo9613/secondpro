using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19
{
    class CovidMenu
    {
        CovidMenuManager cmm = new CovidMenuManager();

        public void Covid_Menu()
        {
            cmm.MainLoop();
        }

        public void Covid_SubMenu()
        {
            cmm.subMenu();
        }

        public void Covid_VaccineMenu()
        {
            cmm.CovidVaccineLoop();
        }
    }
}
