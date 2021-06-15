using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19
{

    //최상위 클래스 (부모)
    class CovidInfo
    {
        public string Name;
        public string Phone;
        public int Age;
        public string Job;

        public void showInfo()
        {

            //Console.CursorLeft = 90;
            //Console.CursorTop = 1;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t\t\t\t\t\t로그인 정보");
                 Console.WriteLine();   
            //Console.CursorLeft = 98;
                //Console.CursorTop = 3;
                Console.WriteLine("\t\t\t\t\t\t이름 : {0}", Name);
                //Console.CursorLeft = 96;
                //Console.CursorTop = 4;  
                Console.WriteLine("\t\t\t\t\t\t전화 : {0}", Phone);
                //Console.CursorLeft = 94;
                //Console.CursorTop = 5;
                Console.WriteLine("\t\t\t\t\t\t나이 : {0}", Age);
                //Console.CursorLeft = 92;
                //Console.CursorTop = 6;
                Console.WriteLine("\t\t\t\t\t\t직업 : {0}", Job);           

        }
    }

    
}
