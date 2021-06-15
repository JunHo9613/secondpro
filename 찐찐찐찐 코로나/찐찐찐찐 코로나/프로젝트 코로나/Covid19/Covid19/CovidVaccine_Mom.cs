using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19
{
    class CovidVaccine_Mom
    {
        
        public virtual void Covid_Info_Pfizer()
        {
          
            Console.WriteLine("\t\t\t\t\t\t제조사 : 화이자 및 바이오엔텍");
            Console.WriteLine("\t\t\t\t\t\t백신명 : 코미나티주");
            Console.WriteLine("\t\t\t\t\t\t연령 : 만 16세 이상");
            Console.WriteLine("\t\t\t\t\t\t구성: 다회 투여용 바이알");
            Console.WriteLine("\t\t\t\t\t\t접종 횟수(간격) : 2회,21일");
            Console.WriteLine("\t\t\t\t\t\t접종량 및 방법 : 희석된 백신 0.3ml 근육주사");
 
        }
        public virtual void Covid_Info_Moderna()
        {

            Console.WriteLine("\t\t\t\t\t\t플랫폼 : mRNA 백신(헥산백신)");
            Console.WriteLine("\t\t\t\t\t\t제조사 : 모더나");
            Console.WriteLine("\t\t\t\t\t\t백신명 : -");
            Console.WriteLine("\t\t\t\t\t\t연령 : 만 18세 이상");
            Console.WriteLine("\t\t\t\t\t\t구성: 다회 투여용 바이알");
            Console.WriteLine("\t\t\t\t\t\t접종 횟수(간격) : 2회,28일");
            Console.WriteLine("\t\t\t\t\t\t접종량 및 방법 : 0.5ml 근육주사");

        }
        public virtual void Covid_Info_Astrazeneca()
        {

            Console.WriteLine("\t\t\t\t\t\t플랫폼 : 바이러스 벡터 백신");
            Console.WriteLine("\t\t\t\t\t\t제조사 : 아스트라제네카");
            Console.WriteLine("\t\t\t\t\t\t백신명 : 한국아스트라제네카코비드-19백신");
            Console.WriteLine("\t\t\t\t\t\t연령 : 만 18세 이상");
            Console.WriteLine("\t\t\t\t\t\t구성: 다회 투여용 바이알");
            Console.WriteLine("\t\t\t\t\t\t접종 횟수(간격) : 2회,8-12주(*2차접종일기준 11~12주)*허가는 4~12주");
            Console.WriteLine("\t\t\t\t\t\t접종량 및 방법 : 0.5ml 근육주사");

        }
        public virtual void Covid_Info_Jansen()
        {

            Console.WriteLine("\t\t\t\t\t\t플랫폼 : 바이러스 벡터 백신");
            Console.WriteLine("\t\t\t\t\t\t제조사 : 얀센 Johnson&Johnson");
            Console.WriteLine("\t\t\t\t\t\t백신명 : 코비드19백신얀센주");
            Console.WriteLine("\t\t\t\t\t\t연령 : 만 18세 이상");
            Console.WriteLine("\t\t\t\t\t\t구성: 다회 투여용 바이알");
            Console.WriteLine("\t\t\t\t\t\t접종 횟수(간격) : 1회");
            Console.WriteLine("\t\t\t\t\t\t접종량 및 방법 : 0.5ml 근육주사");

        }
        public virtual void print_All_Info_Vaccine()
        {   

            Console.WriteLine("\n\n\n");
            Console.WriteLine("=======================================================================================================================");
            Console.WriteLine("    플랫폼     |                     mRNA                 |                  바이러스 벡터 백신                        ");
            Console.WriteLine("    제조사     |        화이자         |     모더나       |     아스트라 제네카        |        얀센                   ");
            Console.WriteLine("    백신명     |      코미나티주       |        -         |       한국 아스트라        |    코비드19백신               ");
            Console.WriteLine("               |          -            |        -         |    제네카 코비드19백신     |       얀센주                  ");
            Console.WriteLine("     연령(만)  |      16세 이상        |   18세 이상      |       18세 이상            |     18세 이상                 ");
            Console.WriteLine("     구성      |      다회 투여용      |   다회 투여용    |       다회 투여용          |     다회투여용                "); 
            Console.WriteLine("               |        바이알         |      바이알      |         바이알             |       바이알                  ");
            Console.WriteLine("   접종 횟수   |        2회 21일       |     2회 28일     |       2회 8-12주           |        1회                    ");
            Console.WriteLine("접종량 및 방법 |   희석된 백신 0.3ml   | 0.5ml 근육주사   |     0.5ml 근육주사         |    0.5ml 근육주사             ");
            Console.WriteLine("               |        근육주사       |                  |                            |                               ");
            Console.WriteLine("=======================================================================================================================");

        }
    }
}
