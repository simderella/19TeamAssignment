using _19teamGroupAssignment;
using System.Threading;

namespace _19teamGroupAssignment
{
    public class Battle
    {
        
        static List<Monster> _monsters = new List<Monster>();
        public static void StartBattle(Character player)
        {
            Random random = new Random();
            Monster[] choices =
            {
            new Monster("미니언", 2, 5, 15),
            new Monster("공허충", 3, 9, 10),
            new Monster("대포미니언", 5, 8, 25)
            };

            int monsterCnt = random.Next(1, 5);

            for (int i = 0; i < monsterCnt; i++)
            {
                Monster monsterType = choices[random.Next(0, 3)].Clone();
                _monsters.Add(monsterType);
            }

            // 랜덤으로 선택한 몬스터 가져오기
            Monster monster = _monsters[random.Next(0, _monsters.Count)];
            Console.WriteLine($"전투가 시작되었습니다.");
            Console.WriteLine();

            while (player.IsAlive && monster.IsAlive)
            {
                DisplayStatus(player);
                Console.WriteLine();
                Console.WriteLine("1. 공격");
                Console.WriteLine("2. 도망가기");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("어떤 몬스터를 공격하시겠습니까?");
                        for (int i = 0; i < _monsters.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. Lv.{_monsters[i].Level} {_monsters[i].Name} HP {_monsters[i].Hp}");
                        }
                        int monsterChoice = InputValidator.CheckValidInput(1, _monsters.Count);
                        PlayerTurn(player, _monsters[monsterChoice - 1]);

                        if (!_monsters[monsterChoice - 1].IsAlive)
                        {
                            Console.WriteLine($"{_monsters[monsterChoice - 1].Name}가 격파되었습니다!");
                            break;
                        }
                        MonsterTurn(player, monster);
                        if (!player.IsAlive)
                        {
                            Console.WriteLine($"{player.Name}가 격파되었습니다!");
                            break;
                        }
                        break;

                    case "2":
                        if (TryEscape())
                        {
                            Console.WriteLine($"{player.Name}이(가) 도망쳤습니다!");
                            return;
                            GameIntro.DisplayMain(); // 도망쳤으면 전투 종료
                        }
                        else
                        {
                            Console.WriteLine($"{player.Name}이(가) 도망에 실패했습니다!");
                            MonsterTurn(player, monster); // 도망치지 못했을 경우 몬스터의 공격
                        }
                        break;

                    default:
                        Console.WriteLine("잘못된 입력입니다. 다시 선택하세요.");
                        break;
                }
            }

            DisplayResult(player, monster);
        }


        private static void DisplayStatus(Character player)
        {
            Console.WriteLine($"[나의 상태] \n{player.Name} 체력: {player.Hp}");

            Console.WriteLine("적 몬스터 체력:");
            for (int i = 0; i < _monsters.Count; i++)
            {
                Console.WriteLine($"\n{i + 1}. Lv.{_monsters[i].Level} {_monsters[i].Name} 체력: {_monsters[i].Hp} ");
            }
        }

        private static bool TryEscape()
        {
            // 도망치기 시도
            Random random = new Random();
            int escapeChance = random.Next(1, 101); // 1부터 100까지의 난수 생성

            if (escapeChance <= 50) // 도망치기 성공 확률 50%
            {
                return true;
            }

            return false;
        }
        private static void DisplayResult(Character player, Monster monster)
        {
            //전투 후 몬스터 리스트 초기화
            _monsters.Clear();
            Console.WriteLine("전투가 종료되었습니다.");

            if (player.IsAlive)
            {
                Console.WriteLine($"{player.Name}이(가) 승리했습니다!");
                Console.WriteLine($"남은 체력: {player.Hp}");
                Console.WriteLine("아무 키나 눌러 귀환합니다...");
                Console.ReadKey();
                
                GameIntro.DisplayMain();
            }
            else if (monster.IsAlive)
            {
                Console.WriteLine($"{monster.Name}이(가) 승리했습니다!");
                Console.WriteLine($"남은 체력: {monster.Hp}");
                Console.WriteLine("아무 키나 눌러 귀환합니다...");
                Console.ReadKey();
                GameIntro.DisplayMain();
            }
            else
            {
                Console.WriteLine($"{player.Name}이(가) 도망쳤습니다!");
                Console.WriteLine("아무 키나 눌러 귀환합니다...");
                Console.ReadKey();
                GameIntro.DisplayMain();
            }
            
        }

        private static void PlayerTurn(Character player, Monster monster)
        {
            Console.WriteLine($"{player.Name}의 차례:");

            int damageDealt = player.Atk;
            if (damageDealt > 0)
            {
                monster.TakeDamage(damageDealt);
                Console.WriteLine($"{player.Name}이(가) {monster.Name}에게 {damageDealt}의 피해를 입혔습니다!");
            }
            else
            {
                Console.WriteLine($"{player.Name}의 공격이 {monster.Name}에게 효과가 없습니다!");
            }
        }

        private static void MonsterTurn(Character player, Monster monster)
        {
            Console.WriteLine($"{monster.Name}의 차례:");

            int damageDealt = monster.Atk - player.Def;
            if (damageDealt > 0)
            {
                player.TakeDamage(damageDealt);
                Console.WriteLine($"{monster.Name}이(가) {player.Name}에게 {damageDealt}의 피해를 입혔습니다!");
            }
            else
            {
                Console.WriteLine($"{monster.Name}의 공격이 {player.Name}에게 효과가 없습니다!");
            }
        }
    }
}