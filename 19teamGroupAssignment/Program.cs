namespace _19teamGroupAssignment
{
    public class Monster
    {
        public string Name { get; }
        public int Level { get; }
        public int Atk { get; }
        public int Hp { get; }

        public static int MonsterCnt = 0;

        public Monster(string name, int level, int atk, int hp)
        {
            Name = name;
            Level = level;
            Atk = atk;
            Hp = hp;
        }

        internal class Program
        {

            static List<Monster> _monsters = new List<Monster>();

            static void GameDataSetting()
            {

                Random random = new Random();
                Monster[] choices =
                {
                    new Monster("미니언",2,5,15),
                    new Monster("공허충",3,9,10),
                    new Monster("대포미니언",5,8,25)
                };
                int monsterCnt = random.Next(1, 5); //랜덤으로 마리수 정하기 1~4 중 하나를 선택


                //리스트화 해서 new Monster 내용이 나오도록
                //몇마리를 뽑을지 랜덤으로 정하기
                //몇마리인지 정해지면 그 횟수 만큼 뽑기
                //List<Monster> list = new List<Monster>();
                //list.Add(new Monster("미니언", 2, 5, 15));
                //list.Add(new Monster("공허충", 5, 9, 10));
                //list.Add(new Monster("대포미니언", 5, 8, 25));

                Console.WriteLine("[몬스터 정보]");

                for (int i = 0; i < monsterCnt; i++) //마리수 정하기
                {
                     Monster monsterType = choices[random.Next(0, 3)];
                    //string monsterType = List<Monster>[random.Next(0, 3)];
                    Console.WriteLine($"Lv.{monsterType.Level} {monsterType.Name}  HP {monsterType.Hp}");
                    _monsters.Add(monsterType);   
                }

                //foreach (string monster in choices)
                //{
                //    Console.WriteLine(monster);
                //}




            }

            //private static void AddMonster(Monster monster)
            //{
            //    if (Monster.MonsterCnt == 4) return;
            //    _monsters[Monster.MonsterCnt] = monster;
            //    Monster.MonsterCnt++;
            //}
            static void BattleStart(Monster monster)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Battle!!");
                Console.ResetColor();
                Console.WriteLine();

                Console.Write($"Lv.{monster.Level} ");
                Console.Write($"{monster.Name}  ");
                Console.Write($"HP {monster.Hp}");
                Console.WriteLine();
                Console.WriteLine("[내정보]");
                //Console.Write("Lv. {player.Level}  ");
                //Console.Write("{player.Name}");
                //Console.Write("({player.Job})");
                //Console.WriteLine("");
                //Console.WriteLine("HP {player.Hp}/{player.Hp}");

                Console.WriteLine("원하시는 행동을 입력해주세요. \n >>");
                Console.WriteLine("1. 공격");
                int input = CheckValidInput(0, 1);
                switch (input)
                {
                    case 0:

                        break;
                    case 1:
                        Console.WriteLine("배틀시작");
                        break;
                }
            }
            static int CheckValidInput(int min, int max)
            {
                while (true)
                {
                    string input = Console.ReadLine();

                    bool parseSuccess = int.TryParse(input, out var ret);
                    if (parseSuccess)
                    {
                        if (ret >= min && ret <= max)
                            return ret;
                    }

                    Console.WriteLine("잘못된 입력입니다.");
                }
            }
            static void Main(string[] args)
            {
                GameDataSetting();
                //BattleStart();
            }

        }
    } 
}