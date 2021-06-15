using _119_MultiThreadChattingPlusClient.OpenChat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19
{
    class CovidMenuManager
    {
        //CovidDao codao = new CovidDao();
        public void MainLoop()
        {
            CovidDao codao = new CovidDao();
            bool isrun = true;
            MainUI();

            while (isrun)
            {
                printMenu();
                int sel = selectMenu();
                Console.Clear();
                switch (sel)
                {
                    case 1:
                        Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t  정보입력");
                        codao.CovidLogin();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t회원가입");
                        codao.Member();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        isrun = false;
                        Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t종료");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t잘못입력하셨습니다.");
                        Console.Clear();
                        break;
                }
            }
        }

        public void printMenu()
        {
            Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t코로나 정보 프로그램");
            Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t1. 정보 입력");
            Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t2. 회원 가입");
            Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t3. 종료");
        }
        public static int selectMenu()
        {
            int sel = 0;
            Console.WriteLine();
            Console.Write("선택 >>");
            sel = Int32.Parse(Console.ReadLine());

            return sel;
        }


        public void subMenu()
        {
            CovidDao codao = new CovidDao();
            CovidConditionMenu ccm = new CovidConditionMenu();
            bool isrun = true;
            while (isrun)
            {
                codao.PrintState(CovidDao.name);
                printSubMenu();
                int sel = selectSubMenu();
                switch (sel)
                {
                    case 1:
                        Console.WriteLine("코로나 발생현황");
                        Console.Clear();
                        ccm.CovidConditionLoop();
                        break;
                    case 2:
                        Console.WriteLine("백신");
                        Console.Clear();
                        CovidVaccineLoop();
                        break;
                    case 3:
                        Console.WriteLine("오픈채팅");
                        Console.Clear();
                        Program.chat();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("잘못입력하셨습니다.");
                        Console.Clear();
                        break;
                }
                if (sel == 4)
                {
                    Console.Clear();
                    Console.WriteLine("처음화면으로 돌아갑니다.");
                    Console.ReadLine();
                    //cmm.MainLoop();
                    break;
                }
            }
        }
        public void printSubMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.WriteLine("\n\t\t\t\t\t\t선택 메뉴");
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t1.코로나 발생 현황");
            Console.WriteLine("\t\t\t\t\t\t2.백신");
            Console.WriteLine("\t\t\t\t\t\t3.오픈채팅");
            Console.WriteLine("\t\t\t\t\t\t4.뒤로가기");
        }
        public int selectSubMenu()
        {
            int sel = 0;
            Console.WriteLine();
            Console.Write("\t\t\t\t\t\t선택 >> ");
            sel = Int32.Parse(Console.ReadLine());

            return sel;
        }


        public void CovidVaccineLoop()
        {
            CovidVaccine_Son cvs = new CovidVaccine_Son();
            Location_lnoculacion_Vaccine liv = new Location_lnoculacion_Vaccine();
            CovidDao codao = new CovidDao();
            int sel = 0;
            while (true)
            {
                Console.Clear();
                
                Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t1. 백신정보");
                Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t2. 지역별 접종 현황");
                Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t3. 나에게 맞는 백신 정보");
                Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t4. 뒤로가기");
                Console.Write("\t\t\t\t\t\t선택 >> ");
                sel = Int32.Parse(Console.ReadLine());

                switch (sel)
                {
                    case 1:
                        Console.Clear();
                        cvs.print_All_Info_Vaccine();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        liv.location_Inoculacion_Vaccine();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("나에게 맞는 백신 정보로 갑니다.");
                        codao.Check_Job();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("잘못 입력했습니다.");
                        break;
                }
                if (sel == 4)
                {
                    Console.Clear();
                    Console.WriteLine("뒤로돌아갑니다");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
            }
        }


        public void MainUI()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("■■■■■■■   ■■■■■■■   ■            ■   ■■■   ■■■■■■■              ■     ■■■■■");
            Console.WriteLine("■               ■          ■    ■          ■      ■     ■            ■            ■     ■      ■");
            Console.WriteLine("■               ■          ■     ■        ■       ■     ■            ■            ■     ■      ■");
            Console.WriteLine("■               ■          ■      ■      ■        ■     ■            ■    ■■    ■     ■■■■■");
            Console.WriteLine("■               ■          ■       ■    ■         ■     ■            ■            ■             ■");
            Console.WriteLine("■               ■          ■        ■  ■          ■     ■            ■            ■             ■");
            Console.WriteLine("■■■■■■■   ■■■■■■■         ■■         ■■■   ■■■■■■■              ■             ■");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("■■■   ■■     ■■  ■■■■■  ■■■■■  ■■■■■   ■          ■       ■    ■■■■■  ■■■  ■■■■■   ■■     ■■");
            Console.WriteLine("  ■     ■ ■     ■   ■          ■      ■  ■       ■  ■          ■      ■■       ■        ■    ■      ■   ■ ■     ■");
            Console.WriteLine("  ■     ■  ■    ■   ■          ■      ■  ■       ■  ■■      ■■     ■  ■      ■        ■    ■      ■   ■  ■    ■");
            Console.WriteLine("  ■     ■   ■   ■   ■■■■■  ■      ■  ■■■■■   ■ ■    ■ ■    ■■■■     ■        ■    ■      ■   ■   ■   ■");
            Console.WriteLine("  ■     ■    ■  ■   ■          ■      ■  ■■         ■  ■  ■  ■   ■      ■    ■        ■    ■      ■   ■    ■  ■");
            Console.WriteLine("  ■     ■     ■ ■   ■          ■      ■  ■   ■      ■   ■■   ■  ■        ■   ■        ■    ■      ■   ■     ■ ■");
            Console.WriteLine("■■■  ■■     ■■   ■          ■■■■■  ■      ■   ■    ■    ■ ■          ■  ■      ■■■  ■■■■■  ■■     ■■");
            Console.ResetColor();

            Console.WriteLine("\n\n\n\n\t\t\t\t\t\tPress Any Key...");
            Console.ReadLine();
            Console.Clear();
        }

    }
}
