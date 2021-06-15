using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19
{
    class CovidConditionMenu
    {
        public void CovidConditionLoop()
        {
            CovidWordAsiaCondition cwac = new CovidWordAsiaCondition();
            CovidWordMiddleEastCondition cwmec = new CovidWordMiddleEastCondition();
            CovidWordEuropeCondition cwec = new CovidWordEuropeCondition();
            CovidWordAmericaCondition cwamc = new CovidWordAmericaCondition();
            CovidWordOceaniaCondition cwoc = new CovidWordOceaniaCondition();
            CovidWordEtcCondition cwetcc = new CovidWordEtcCondition();
            CovidWordAllCondition cwall = new CovidWordAllCondition();
            int sel1 = 0;
            int sel = 0;
            while (true)
            {
                CovidCondition cd = new CovidCondition();
                Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t코로나 현상황 확인");
                Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t1. 국내 확진자");
                Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t2. 국외 확진자");
                Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t3. 전 세계 총 확진자");
                Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t4. 뒤로가기");
                Console.WriteLine();
                Console.Write("번호 선택 >>");
                sel = Int32.Parse(Console.ReadLine());
                switch (sel)
                {
                    case 1:
                        ClearScreen();
                        Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t[국내]");                     
                        Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t1. 확진자");
                        Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t2. 격리해제");
                        Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t3. 사망자");
                        Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t4. 뒤로가기");
                        Console.WriteLine();
                        Console.Write("번호 선택 >>");
                        sel1 = Int32.Parse(Console.ReadLine());
                        switch (sel1)
                        {
                            case 1:
                                ClearScreen();
                                cd.coronic();   //국내 지역별 확진자
                                Console.ReadLine();
                                ClearScreen();
                                break;
                            case 2:
                                ClearScreen();
                                cd.unlockdown();    //국내 격리해제
                                Console.ReadLine();
                                ClearScreen();
                                break;
                            case 3:
                                ClearScreen();
                                cd.dead();   //국내 사망자
                                Console.ReadLine();
                                ClearScreen();
                                break;
                            case 4:
                                ClearScreen();
                                Console.WriteLine("뒤로 돌아갑니다.");
                                Console.ReadLine();
                                ClearScreen();
                                break;
                            default:
                                Console.WriteLine("잘못입력하셨습니다.");
                                break;
                        }
                        break;
                    case 2:
                        ClearScreen();
                        Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t[국외]");
                        Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t1. 확진자");
                        Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t2. 사망자");
                        Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t3. 뒤로가기");
                        Console.WriteLine();
                        Console.Write("번호 선택 >>");
                        sel1 = Int32.Parse(Console.ReadLine());
                        switch (sel1)
                        {
                            case 1:
                                //국외 지역별 확진자
                                ClearScreen();
                                cwac.coronic();     // 아시아 확진자
                                cwmec.coronic();    // 중동 확진자
                                cwec.coronic();     // 유럽 확진자
                                cwamc.coronic();    // 아메리카 확진자
                                cwoc.coronic();     // 오세니아 확진자
                                cwetcc.coronic();   // 기타 영토 확진자
                                Console.ReadLine();
                                ClearScreen();
                                break;
                            case 2:
                                ClearScreen();
                                cwac.dead();   // 아시아 사망자
                                cwmec.dead();  // 중동 사망자
                                cwec.dead();   // 유럽 사망자
                                cwamc.dead();  // 아메리카 사망자
                                cwoc.dead();   // 오세니아 사망자
                                cwetcc.dead(); // 기타영토 사망자
                                Console.ReadLine();
                                ClearScreen();
                                break;
                            case 3:
                                ClearScreen();
                                Console.WriteLine("뒤로 돌아갑니다.");
                                Console.ReadLine();
                                ClearScreen();
                                break;
                            default:
                                Console.WriteLine("잘못입력하셨습니다.");
                                break;
                        }
                        if (sel == 3)
                        {
                            break;
                        }
                        break;
                    case 3:
                        ClearScreen();
                        cwall.coronic();
                        cwall.unlockdown();
                        cwall.dead();
                        Console.ReadLine();
                        ClearScreen();
                        break;
                    default:
                        Console.WriteLine("잘못 입력했습니다.");
                        break;

                        //나가기 처리
                }
                if (sel == 3)
                {
                    Console.Clear();
                    Console.WriteLine("뒤로 돌아갑니다");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
            }
        }

        static void ClearScreen()
        {
            Console.Clear();
        }
    }
}


