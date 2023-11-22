using _19teamGroupAssignment;
using System.Threading;

namespace _19teamGroupAssignment
{
    public class Battle
    {
        
        static List<Monster> _monsters = new List<Monster>();
        public static void StartBattle(Character player, Monster monster)
        {
            Random random = new Random();
            Monster[] choices =
            {
                    new Monster("미니언",2,5,15),
                    new Monster("공허충",3,9,10),
                    new Monster("대포미니언",5,8,25)
                };
            int monsterCnt = random.Next(1, 5);

            for (int i = 0; i < monsterCnt; i++) //마리수 정하기
            {
                Monster monsterType = choices[random.Next(0, 3)];
                Console.WriteLine($"Lv.{monsterType.Level} {monsterType.Name}  HP {monsterType.Hp}");
                _monsters.Add(monsterType);
            }
            Console.WriteLine($"Lv.{monster.Level} {monster.Name} HP {monster.Hp}");

            Console.WriteLine($"전투가 시작되었습니다. {player.Name} vs {monster.Name}");

            while (player.IsAlive && monster.IsAlive)
            {
                DisplayStatus(player, monster);

                Console.WriteLine("1. 공격");
                Console.WriteLine("2. 도망가기");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PlayerTurn(player, monster);
                        if (!monster.IsAlive)
                        {
                            Console.WriteLine($"{monster.Name}가 격파되었습니다!");
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
                            return; // 도망쳤으면 전투 종료
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

        private static void DisplayStatus(Character player, Monster monster)
        {
            Console.WriteLine($"[전투 상태] {player.Name} 체력: {player.Hp}, {monster.Name} 체력: {monster.Hp}");
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
            Console.WriteLine("전투가 종료되었습니다.");

            if (player.IsAlive)
            {
                Console.WriteLine($"{player.Name}이(가) 승리했습니다!");
                Console.WriteLine($"남은 체력: {player.Hp}");
                Console.WriteLine($"획득 골드: {player.Gold}");
            }
            else if (monster.IsAlive)
            {
                Console.WriteLine($"{monster.Name}이(가) 승리했습니다!");
                Console.WriteLine($"남은 체력: {monster.Hp}");
            }
            else
            {
                Console.WriteLine($"{player.Name}이(가) 도망쳤습니다!");
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