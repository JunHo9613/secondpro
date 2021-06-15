using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19
{
    class CovidCondition
    {
        public virtual void coronic()
        {
            Console.WriteLine("\n\n\n\t\t\t       지역확진자");
            Console.WriteLine("\t\t\t\t\t\t\t\t2021.06.14기준");
            Console.Write("\n\n\t\t\t     서울:46600명");
            Console.Write("\n\n\t\t\t     울산:2678명");
            Console.Write("\n\n\t\t\t     부산:5943명");
            Console.Write("\n\n\t\t\t     대구:10438명");
            Console.Write("\n\n\t\t\t     광주:2868명");
            Console.Write("\n\n\t\t\t     대전:2349명");
            Console.Write("\n\n\t\t\t     인천:6446명");
            Console.WriteLine();
            Console.WriteLine("\n\n\n\t\t\t      국내 총 확진자");
            Console.WriteLine("\t\t\t\t\t\t\t\t");
            Console.Write("\n\n\t\t\t  국내 전체 확진자:148,273명");
            Console.WriteLine();
        }


        public virtual void unlockdown()
        {
            Console.WriteLine("\n\n\n\t\t\t       격리해제");
            Console.WriteLine("\t\t\t\t\t\t\t\t가상의 값입니다");
            Console.Write("\n\n\t\t\t     서울:498명");
            Console.Write("\n\n\t\t\t     울산:260명");
            Console.Write("\n\n\t\t\t     부산:549명");
            Console.Write("\n\n\t\t\t     대구:1026명");
            Console.Write("\n\n\t\t\t     광주:297명");
            Console.Write("\n\n\t\t\t     대전:229명");
            Console.Write("\n\n\t\t\t     인천:67명");
            Console.WriteLine();
            Console.WriteLine("\n\n\n\t\t\t국내 총 격리해제");
            Console.WriteLine("\t\t\t\t\t\t\t\t2021.06.14기준");
            Console.Write("\n\n\t\t\t     격리해제:139,022명");
            Console.WriteLine();
        }


        public virtual void dead()
        {
            Console.WriteLine("\n\n\n\t\t\t국내사망자:1,988명");
            Console.WriteLine("\n\n\n\t\t\t2021.06.14기준");
            Console.WriteLine();

        }


    }

    class CovidWordAsiaCondition : CovidCondition
    {
        public override void coronic()
        {
            Console.WriteLine("\n\n\n\t\t\t       국외누적확진자");
            Console.WriteLine("\n\n\n\t\t\t\t       [아시아]");
            Console.WriteLine("\t\t\t\t\t\t\t\t2021.06.14기준");
            Console.Write("\n\n\t\t\t     중국:91,428명");
            Console.Write("\n\n\t\t\t     일본:771,840명");
            Console.Write("\n\n\t\t\t     인도:29,359,155명");
            Console.Write("\n\n\t\t\t     인도네시아:1,894,025명");
            Console.Write("\n\n\t\t\t     베트남:10,048명");
            Console.Write("\n\n\t\t\t     태국:193,105명");
            Console.Write("\n\n\t\t\t     필리핀:1,300,349명");
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
        }
        public override void dead()
        {
            Console.WriteLine("\n\n\n\t\t\t아시아 누적사망자");
            Console.WriteLine("\n\n\n\t\t\t2021.06.14기준");
            Console.WriteLine();
            Console.Write("\n\n\t\t\t     중국:4,636명");
            Console.Write("\n\n\t\t\t     일본:13,976명");
            Console.Write("\n\n\t\t\t     인도:367,081명");
            Console.Write("\n\n\t\t\t     인도네시아: 52,566명");
            Console.Write("\n\n\t\t\t     베트남: 57명");
            Console.Write("\n\n\t\t\t     태국:1,431명");
            Console.Write("\n\n\t\t\t     필리핀:22,507명");
            Console.ReadLine();
            Console.Clear();
        }


    }
    class CovidWordMiddleEastCondition : CovidCondition
    {
        public override void coronic()
        {
            Console.WriteLine("\n\n\n\t\t\t       국외누적확진자");
            Console.WriteLine("\n\n\n\t\t\t\t       [중동]");
            Console.WriteLine("\t\t\t\t\t\t\t\t2021.06.14기준");
            Console.Write("\n\n\t\t\t     이란:3,013,078명");
            Console.Write("\n\n\t\t\t     이집트:271,780명");
            Console.Write("\n\n\t\t\t     이라크:1,246,860명");
            Console.Write("\n\n\t\t\t     요르단:742,521명");
            Console.Write("\n\n\t\t\t     이스라엘:839,653명");
            Console.Write("\n\n\t\t\t     아랍에미리트:593,894명");
            Console.Write("\n\n\t\t\t     모로코:523,165명");
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
        }
        public override void dead()
        {
            Console.WriteLine("\n\n\n\t\t\t중동 누적사망자");
            Console.WriteLine("\n\n\n\t\t\t2021.06.14기준");
            Console.WriteLine();
            Console.Write("\n\n\t\t\t     이란:81,796명");
            Console.Write("\n\n\t\t\t     이집트:15,547명");
            Console.Write("\n\n\t\t\t     이라크:16,668명");
            Console.Write("\n\n\t\t\t     요르단:9,577명");
            Console.Write("\n\n\t\t\t     이스라엘:6,428명");
            Console.Write("\n\n\t\t\t     아랍에미리트:1,720명");
            Console.Write("\n\n\t\t\t     모로코:9,202명");
            Console.ReadLine();
            Console.Clear();
        }
    }
    class CovidWordEuropeCondition : CovidCondition
    {
        public override void coronic()
        {
            Console.WriteLine("\n\n\n\t\t\t       국외누적확진자");
            Console.WriteLine("\n\n\n\t\t\t\t       [유럽]");
            Console.WriteLine("\t\t\t\t\t\t\t\t2021.06.14기준");
            Console.Write("\n\n\t\t\t     이탈리아:4,241,760명");
            Console.Write("\n\n\t\t\t     독일:3,713,480명");
            Console.Write("\n\n\t\t\t     프랑스:5,629,389명");
            Console.Write("\n\n\t\t\t     인도네시아:1,894,025명");
            Console.Write("\n\n\t\t\t     영국:4,550,948명");
            Console.Write("\n\n\t\t\t     스페인:3,729,458명");
            Console.Write("\n\n\t\t\t     오스트리아:644,147명");
            Console.Write("\n\n\t\t\t     크로아티아:358,504명");
            Console.Write("\n\n\t\t\t     스웨덴:1,083,456명");
            Console.Write("\n\n\t\t\t     벨기에:1,074,988명");
            Console.Write("\n\n\t\t\t     루마니아:1,079,530명");
            Console.Write("\n\n\t\t\t     네덜란드:1,670,498명");
            Console.Write("\n\n\t\t\t     체코:1,665,022명");
            Console.Write("\n\n\t\t\t     폴란드:1,665,022명");
            Console.Write("\n\n\t\t\t     우크라이나:2,222,701명");
            Console.Write("\n\n\t\t\t     터키:5,319,359명");
            Console.Write("\n\n\t\t\t     러시아:5,193,964명");
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
        }
        public override void dead()
        {
            Console.WriteLine("\n\n\n\t\t\t유럽 누적사망자");
            Console.WriteLine("\n\n\n\t\t\t2021.06.14기준");
            Console.WriteLine();
            Console.Write("\n\n\t\t\t     이탈리아:126,924명");
            Console.Write("\n\n\t\t\t     독일:89,816명");
            Console.Write("\n\n\t\t\t     프랑스:109,475명");
            Console.Write("\n\n\t\t\t     영국:127,884명");
            Console.Write("\n\n\t\t\t     스페인:80,465명");
            Console.Write("\n\n\t\t\t     오스트리아:10,394명");
            Console.Write("\n\n\t\t\t     크로아티아:8,132명");
            Console.Write("\n\n\t\t\t     스웨덴:14,574명");
            Console.Write("\n\n\t\t\t     벨기에:25,075명");
            Console.Write("\n\n\t\t\t     루마니아:31,681명");
            Console.Write("\n\n\t\t\t     네덜란드:17,708명");
            Console.Write("\n\n\t\t\t     체코:30,224명");
            Console.Write("\n\n\t\t\t     폴란드:74,562명");
            Console.Write("\n\n\t\t\t     우크라이나:51,646명");
            Console.Write("\n\n\t\t\t     터키:48,593명");
            Console.Write("\n\n\t\t\t     러시아:126,073명");
            Console.ReadLine();
            Console.Clear();
        }
    }

    class CovidWordAmericaCondition : CovidCondition
    {
        public override void coronic()
        {
            Console.WriteLine("\n\n\n\t\t\t       국외누적확진자");
            Console.WriteLine("\n\n\n\t\t\t\t       [아메리카]");
            Console.WriteLine("\t\t\t\t\t\t\t\t2021.06.14기준");
            Console.Write("\n\n\t\t\t     미국:33,108,269명");
            Console.Write("\n\n\t\t\t     캐나다:1,398,274명명");
            Console.Write("\n\n\t\t\t     멕시코:2,445,538명");
            Console.Write("\n\n\t\t\t     브라질:17,210,969명");
            Console.Write("\n\n\t\t\t     페루:1,995,257명");
            Console.Write("\n\n\t\t\t     칠레:1,461,419명");
            Console.Write("\n\n\t\t\t     콜롬비아:3,665,137명");
            Console.Write("\n\n\t\t\t     볼리비아:400,047명");
            Console.Write("\n\n\t\t\t     아르헨티나:4,066,156명");
            Console.Write("\n\n\t\t\t     도미니카공화국:3,700명");
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
        }
        public override void dead()
        {
            Console.WriteLine("\n\n\n\t\t\t아메리카 누적사망자");
            Console.WriteLine("\n\n\n\t\t\t2021.06.14기준");
            Console.WriteLine();
            Console.Write("\n\n\t\t\t     미국:593,878명");
            Console.Write("\n\n\t\t\t     캐나다:25,873명");
            Console.Write("\n\n\t\t\t     멕시코:229,580명");
            Console.Write("\n\n\t\t\t     브라질:482,019명");
            Console.Write("\n\n\t\t\t     페루:187,847명");
            Console.Write("\n\n\t\t\t     칠레:30,472명");
            Console.Write("\n\n\t\t\t     콜롬비아:94,046명");
            Console.Write("\n\n\t\t\t     볼리비아:15,321명");
            Console.Write("\n\n\t\t\t     아르헨티나:83,941명");
            Console.Write("\n\n\t\t\t     도미니카공화국:3,700명");
            Console.ReadLine();
            Console.Clear();
        }
    }
        class CovidWordOceaniaCondition : CovidCondition
        {
            public override void coronic()
            {
                Console.WriteLine("\n\n\n\t\t\t       국외확진자");
                Console.WriteLine("\n\n\n\t\t\t\t       [오세아니아]");
                Console.WriteLine("\t\t\t\t\t\t\t\t2021.06.14기준");
                Console.Write("\n\n\t\t\t     호주:30,229명");
                Console.Write("\n\n\t\t\t     뉴질랜드:2,346명");
                Console.Write("\n\n\t\t\t     피지:970명");
                Console.Write("\n\n\t\t\t     파푸아뉴기니:16,661명");
                Console.Write("\n\n\t\t\t     마셜제도:4명");
                Console.Write("\n\n\t\t\t     솔로몬제도:20명");
                Console.Write("\n\n\t\t\t     바누아투:3명");
                Console.Write("\n\n\t\t\t     사모아:1명");
                Console.WriteLine();
                Console.ReadLine();
                Console.Clear();
        }
            public override void dead()
            {
                Console.WriteLine("\n\n\n\t\t\t오세아니아 누적사망자");
                Console.WriteLine("\n\n\n\t\t\t2021.06.14기준");
                Console.WriteLine();
                Console.Write("\n\n\t\t\t     호주:910명");
                Console.Write("\n\n\t\t\t     뉴질랜드:26명");
                Console.Write("\n\n\t\t\t     피지:4명");
                Console.Write("\n\n\t\t\t     파푸아뉴기니:164명");
                Console.Write("\n\n\t\t\t     마셜제도:0명");
                Console.Write("\n\n\t\t\t     솔로몬제도:0명");
                Console.Write("\n\n\t\t\t     바누아투:0명");
                Console.Write("\n\n\t\t\t     사모아:0명");
                Console.ReadLine();
                Console.Clear();
        }

        }
        class CovidWordAfricaCondition : CovidCondition
        {
            public override void coronic()
            {
                Console.WriteLine("\n\n\n\t\t\t       국외확진자");
                Console.WriteLine("\n\n\n\t\t\t\t       [아프리카]");
                Console.WriteLine("\t\t\t\t\t\t\t\t2021.06.14기준");
                Console.Write("\n\n\t\t\t     나이지리아:167,051명");
                Console.Write("\n\n\t\t\t     세네갈:41,900명");
                Console.Write("\n\n\t\t\t     카메룬:79,904명");
                Console.Write("\n\n\t\t\t     남아프리카공화국:1,730,106명");
                Console.Write("\n\n\t\t\t     수단:36,203명");
                Console.Write("\n\n\t\t\t     에티오피아:273,892명");
                Console.Write("\n\n\t\t\t     케냐:174,773명");
                Console.Write("\n\n\t\t\t     잠비아:107,974명");
                Console.Write("\n\n\t\t\t     짐바브웨:39,688명");
                Console.Write("\n\n\t\t\t     마다가스카르:41,869명");
                Console.Write("\n\n\t\t\t     보츠와나:62,040명");
                Console.Write("\n\n\t\t\t     말라위:34,470명");
                Console.WriteLine();
                Console.ReadLine();
                Console.Clear();
        }
            public override void dead()
            {
                Console.WriteLine("\n\n\n\t\t\t아프리카 누적사망자");
                Console.WriteLine("\n\n\n\t\t\t2021.06.14기준");
                Console.WriteLine();
                Console.Write("\n\n\t\t\t     나이지리아:2,117명");
                Console.Write("\n\n\t\t\t     세네갈:1,150명");
                Console.Write("\n\n\t\t\t     카메룬:1,302명");
                Console.Write("\n\n\t\t\t     남아프리카공화국:57,591명");
                Console.Write("\n\n\t\t\t     수단:2,719명");
                Console.Write("\n\n\t\t\t     에티오피아:4,235명");
                Console.Write("\n\n\t\t\t     케냐:3,378명");
                Console.Write("\n\n\t\t\t     잠비아:1,348명");
                Console.Write("\n\n\t\t\t     짐바브웨:1,629명");
                Console.Write("\n\n\t\t\t     마다가스카르:879명");
                Console.Write("\n\n\t\t\t     보츠와나:896명");
                Console.Write("\n\n\t\t\t     말라위:1,158명");
                Console.ReadLine();
                Console.Clear();
        }

        }
        class CovidWordEtcCondition : CovidCondition
        {
            public override void coronic()
            {
                Console.WriteLine("\n\n\n\t\t\t       국외확진자");
                Console.WriteLine("\n\n\n\t\t\t\t       [기타영토]");
                Console.WriteLine("\t\t\t\t\t\t\t\t2021.06.14기준");
                Console.Write("\n\n\t\t\t     기타지역 영토:658,727명");
                Console.WriteLine();
        }
            public override void dead()
            {
                Console.WriteLine("\n\n\n\t\t\t기타지역 영토 누적사망자");
                Console.WriteLine("\n\n\n\t\t\t2021.06.14기준");
                Console.Write("\n\n\t\t\t     기타지역 영토:8,083명");
            }
        }

        class CovidWordAllCondition : CovidCondition
        {
            public override void coronic()
            {
                Console.WriteLine("\n\n\n\t\t\t       전체총확진자");
                Console.WriteLine("\t\t\t\t\t\t\t\t2021.06.14기준");
                Console.WriteLine("\n\n\n\n\t\t\t       [전 세계 코로나 확진자]");
                Console.Write("\t\t\t     총 확진자:176,820,492명");
                Console.WriteLine();
        }
            public override void unlockdown()
            {
                Console.WriteLine("\n\n\n\n\t\t\t       [전 세계 격리해제]");
                Console.Write("\t\t\t     총 격리해제:159,128,078명");
                Console.WriteLine();
        }

            public override void dead()
            {
                Console.WriteLine("\n\n\n\n\t\t\t       [전 세계 누적사망자]");
                Console.Write("\t\t\t     총 사망자:3,821,778명");
            }
        }







    }

