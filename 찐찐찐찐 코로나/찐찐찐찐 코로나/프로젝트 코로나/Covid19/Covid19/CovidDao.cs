using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Covid19
{
    class CovidDao
    {
        public static string name;
        public static string phone;
        public static int age;
        public static string job;
        public static SqlConnection conn = null;
        public static string connInfo = "Server=localhost;database=CovidData1;uid=Covid;pwd=p1234";
        CovidInfo coInfo = new CovidInfo();
        CovidMenuManager cm = new CovidMenuManager();
        public CovidDao()
        {
            conn = new SqlConnection(connInfo);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t  삐-빅 접속성공,,");
                    Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t 엔터를 눌러주세오");
                    Console.ReadKey();
                    Console.Clear();
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        ~CovidDao()
        {
            if (conn != null)
                conn.Close();
        }
        public void Member()
        {
            Console.Write("\n\n\n\n\n\t\t\t\t\t\t이름: ");
            name = Console.ReadLine();
            Console.Write("\n\n\n\n\n\t\t\t\t\t\t전화번호: ");
            phone = Console.ReadLine();
            Console.Write("\n\n\n\n\n\t\t\t\t\t\t나이: ");
            age = Int32.Parse(Console.ReadLine());
            int sel = 0;
            if (age >= 20)
            {
                Console.Clear();
                JobMenu(); 
                Console.Write("번호 선택 >>");
                sel = Int32.Parse(Console.ReadLine());        
                switch (sel)
                {
                    case 1:
                        Console.WriteLine("1.교사");
                        job = "교사";
                        coInfo.Job = job;
                        break;
                    case 2:
                        Console.WriteLine("2.군인");
                        job = "군인";
                        coInfo.Job = job;
                        break;
                    case 3:
                        Console.WriteLine("3.의료종사자");
                        job = "의료종사자";
                        coInfo.Job = job;
                        break;
                    case 4:
                        Console.WriteLine("4.일반");
                        Console.WriteLine();
                        job = "일반";
                        coInfo.Job = job;
                        break;                     
                    default:
                        Console.WriteLine("잘못된 선택입니다.");
                        break;
                }
            }
            else
            {
                if (age == 19)
                {
                    Console.WriteLine("19살 수험생입니다.");
                    job = "19살수험생";
                    coInfo.Job = job;
                }
                else {
                    Console.WriteLine("학생");
                    job = "학생";
                    coInfo.Job = job;
                }
            }

            coInfo.Name = name;
            coInfo.Age = age;
            coInfo.Phone = phone;


            insertCovidData(coInfo);
        }
        public void JobMenu()
        {

            Console.Write("\n\n\n\n\t\t\t\t\t\t당신은 성인입니다.");
            Console.WriteLine("\n\t\t\t\t\t\t해당되는 직업군 이십니까?");
            Console.WriteLine("\n\t\t\t\t\t\t없으시면 일반을 눌러주세요");
  
            Console.Write("\n\n\n\n\n\t\t\t\t\t\t1.교사");
            Console.Write("\n\n\n\n\n\t\t\t\t\t\t2.군인");
            Console.Write("\n\n\n\n\n\t\t\t\t\t\t3.의료종사자");
            Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t4.일반");
            
        }
        public void insertCovidData(CovidInfo covidInfo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into dbo.CovidInfo values(@이름,@전화,@나이,@직업)";
                    cmd.Parameters.AddWithValue("@이름", covidInfo.Name);
                    cmd.Parameters.AddWithValue("@전화", covidInfo.Phone);
                    cmd.Parameters.AddWithValue("@나이", covidInfo.Age);
                    cmd.Parameters.AddWithValue("@직업", covidInfo.Job);
                    int cnt = cmd.ExecuteNonQuery();
                    Console.WriteLine(cnt + "입력완료");
                    Console.ReadKey();
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
        public void CovidLogin()
        {
            Console.Write("\n\n\n\n\n\t\t\t\t\t\t이름: ");
            name = Console.ReadLine();
            Console.Write("\n\n\n\n\n\t\t\t\t\t\t전화번호: ");
            phone = Console.ReadLine();

            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from dbo.CovidInfo where Name=@이름 and Phone=@전화번호";
                    cmd.Parameters.AddWithValue("@이름", name);
                    cmd.Parameters.AddWithValue("@전화번호", phone);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string[] datas = new string[reader.FieldCount];
                        for (int i = 0; i < reader.FieldCount; i++)
                            datas[i] = reader.GetValue(i).ToString();
                        coInfo.Name = datas[0];
                        coInfo.Phone = datas[1];
                        if (coInfo.Name == name && coInfo.Phone == phone)
                        {
                            Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t로그인 되었습니다.");
                            Console.ReadLine();
                            Console.Clear();
                            cm.subMenu();
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t로그인에 실패하였습니다.");
                        Console.ReadKey();
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
        public void PrintState(string Name)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from dbo.CovidInfo where name=@이름";
                    cmd.Parameters.AddWithValue("@이름", Name);

                    SqlDataReader reader = cmd.ExecuteReader();

                    string[] datas = new string[reader.FieldCount];
                    if (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                            datas[i] = reader.GetValue(i).ToString();

                        coInfo.Name = datas[0];
                        coInfo.Phone = datas[1];
                        coInfo.Age = (Int32.Parse(datas[2]));
                        coInfo.Job = datas[3];
                        job = datas[3];
                        coInfo.showInfo();
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }

        public void Check_Job()
        {
            PrintState(CovidDao.name);
            CovidInfo coInfo = new CovidInfo();
            Inoculacion_Info_Check llc = new Inoculacion_Info_Check();
            
            
                if (job == "의료종사자")
                {
                    Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t의료 종사자 입니다.");

                    llc.health_Professional();
                }
                if (job == "교사")
                {
                    Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t교사 입니다.");

                    llc.teacher();
                }
                if (job == "군인")
                {
                    Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t군인 입니다.");

                    llc.soldier();
                }
                if (job == "일반")
                {
                    Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t일반 입니다.");

                    llc.Normal();
                }
                if (job == "19살수험생")
                {
                    Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t19살수험생 입니다.");

                    llc.Suneung();
                }
                if (job == "학생")
                {
                    Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t학생입니다.");
                }
            
        }
           
        
    }
}
