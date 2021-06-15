using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19
{
    class Inoculacion_Info_Check
    {
        CovidMenuManager cm = new CovidMenuManager();

        public void highschool_3Year() //고등학생 3학년
        {
            CovidVaccine_Son vcson = new CovidVaccine_Son();
            Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t회원님의 배정된 백신은 \"화이자\" 입니다.");
            Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t화이자 에 대한 자세한 정보를 원하시면 0을 입력해주세요");
            Console.Write("\n\n\n\n\n\t\t\t\t\t\t입력 : ");
            int moreInfo = Int32.Parse(Console.ReadLine());
            if (moreInfo == 0)
            {
                vcson.Covid_Info_Astrazeneca();
            }
            else
            {
                Console.WriteLine("잘못 입력하셨습니다. 뒤로 돌아갑니다.");
            }
        }
        public void health_Professional() // 의료종사자
        {
            CovidVaccine_Son vcson = new CovidVaccine_Son();
            Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t의료종사자 입니다. 배정된 백신은 \"아스트라제네카\" 입니다.");
            Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t아스트라제네카 에 대한 자세한 정보를 원하시면 0을 입력해주세요");
            Console.Write("\n\n\n\n\n\t\t\t\t\t\t입력 : ");
            int moreInfo = Int32.Parse(Console.ReadLine());
            if (moreInfo == 0)
            {
                vcson.Covid_Info_Astrazeneca();
            }
            else
            {
                Console.WriteLine("잘못 입력하셨습니다. 뒤로 돌아갑니다.");
            }
        }

        public void teacher() // 교사
        {
            CovidVaccine_Son vcson = new CovidVaccine_Son();
            Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t교사 입니다. 배정된 백신은 \"화이자\" 입니다.");
            Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t화이자 에 대한 자세한 정보를 원하시면 0을 입력해주세요");
            Console.Write("\n\n\n\n\n\t\t\t\t\t\t입력 : ");
            int moreInfo = Int32.Parse(Console.ReadLine());
            if (moreInfo == 0)
            {
                vcson.Covid_Info_Astrazeneca();
            }
            else
            {
                Console.WriteLine("잘못 입력하셨습니다. 뒤로 돌아갑니다.");
            }
        }

        public void soldier() // 군인
        {
            CovidVaccine_Son vcson = new CovidVaccine_Son();
            Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t군인 입니다. 배정된 백신은 \"얀센\" 입니다.");
            Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t얀센 에 대한 자세한 정보를 원하시면 0을 입력해주세요");
            Console.Write("\n\n\n\n\n\t\t\t\t\t\t입력 : ");
            int moreInfo = Int32.Parse(Console.ReadLine());
            if (moreInfo == 0)
            {
                vcson.Covid_Info_Astrazeneca();
            }
            else
            {
                Console.WriteLine("잘못 입력하셨습니다. 뒤로 돌아갑니다.");
            }
        }

        public void Normal() // 일반
        {
            CovidVaccine_Son vcson = new CovidVaccine_Son();
            Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t일반인 입니다. 배정된 백신은 \"모더나\"입니다.");
            Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t모더나 에 대한 자세한 정보를 원하시면 0을 입력해주세요");
            Console.Write("\n\n\n\n\n\t\t\t\t\t\t입력 : ");
            int moreInfo = Int32.Parse(Console.ReadLine());
            if (moreInfo == 0)
            {
                vcson.Covid_Info_Astrazeneca();
            }
            else
            {
                Console.WriteLine("잘못 입력하셨습니다. 자세히 보려면 0을 입력해주세요");
            }
        }

        public void Suneung()
        {
            CovidVaccine_Son vcson = new CovidVaccine_Son();
            Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t19살 수험생입니다. 배정된 백신은 \"화이자\"입니다.");
            Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t화이자 에 대한 자세한 정보를 원하시면 \"0\"을 입력해주세요");
            int moreInfo = Int32.Parse(Console.ReadLine());
            if (moreInfo == 0)
            {
                vcson.Covid_Info_Pfizer();
            }
            else
            {
                Console.WriteLine("잘못 입력하셨습니다. 뒤로 돌아갑니다.");
            }
        }
        public void Student()
        {
            CovidVaccine_Son vcson = new CovidVaccine_Son();
            Console.WriteLine("학생입니다. 배정된 백신은 없습니다.");
            Console.WriteLine("19세미만은 백신을 맞을 수 없습니다.");
        }
    }
}

