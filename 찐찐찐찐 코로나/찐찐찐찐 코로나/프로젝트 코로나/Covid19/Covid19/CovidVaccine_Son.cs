using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19
{
    class CovidVaccine_Son : CovidVaccine_Mom
    {
        public override void Covid_Info_Pfizer()
        {
            base.Covid_Info_Pfizer();
        }
        public override void Covid_Info_Moderna()
        {
            base.Covid_Info_Moderna();
        }
        public override void Covid_Info_Astrazeneca()
        {
            base.Covid_Info_Astrazeneca();
        }
        public override void Covid_Info_Jansen()
        {
            base.Covid_Info_Jansen();
        }

        public override void print_All_Info_Vaccine()
        {
            base.print_All_Info_Vaccine();
        }
    }
}
