using _19teamGroupAssignment;

namespace RtanGame
{
    public class Battle
    {
        public static void StartBattle(Character player, Monster enemy)
        {
            Console.WriteLine($"전투가 시작되었습니다. {player.Name} vs {enemy.Name}");

            while (player.IsAlive && enemy.IsAlive)
            {
                DisplayStatus(player, enemy);

                Console.WriteLine("1. 공격");
                Console.WriteLine("2. 도망가기");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PlayerTurn(player, enemy);
                        if (!enemy.IsAlive)
                        {
                            Console.WriteLine($"{enemy.Name}가 격파되었습니다!");
                            break;
                        }
                        MonsterTurn(player, enemy);
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
                            MonsterTurn(player, enemy); // 도망치지 못했을 경우 몬스터의 공격
                        }
                        break;

                    default:
                        Console.WriteLine("잘못된 입력입니다. 다시 선택하세요.");
                        break;
                }
            }

            DisplayResult(player, enemy);
        }

        private static void DisplayStatus(Character player, Monster enemy)
        {
            Console.WriteLine($"[전투 상태] {player.Name} 체력: {player.Hp}, {enemy.Name} 체력: {enemy.Hp}");
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
        private static void DisplayResult(Character player, Monster enemy)
        {
            Console.WriteLine("전투가 종료되었습니다.");

            if (player.IsAlive)
            {
                Console.WriteLine($"{player.Name}이(가) 승리했습니다!");
                Console.WriteLine($"남은 체력: {player.Hp}");
                Console.WriteLine($"획득 골드: {player.Gold}");
            }
            else if (enemy.IsAlive)
            {
                Console.WriteLine($"{enemy.Name}이(가) 승리했습니다!");
                Console.WriteLine($"남은 체력: {enemy.Hp}");
            }
            else
            {
                Console.WriteLine($"{player.Name}이(가) 도망쳤습니다!");
            }
        }

        private static void PlayerTurn(Character player, Monster enemy)
        {
            Console.WriteLine($"{player.Name}의 차례:");

            int damageDealt = player.Atk;
            if (damageDealt > 0)
            {
                enemy.TakeDamage(damageDealt);
                Console.WriteLine($"{player.Name}이(가) {enemy.Name}에게 {damageDealt}의 피해를 입혔습니다!");
            }
            else
            {
                Console.WriteLine($"{player.Name}의 공격이 {enemy.Name}에게 효과가 없습니다!");
            }
        }

        private static void MonsterTurn(Character player, Monster enemy)
        {
            Console.WriteLine($"{enemy.Name}의 차례:");

            int damageDealt = enemy.Atk - player.Def;
            if (damageDealt > 0)
            {
                player.TakeDamage(damageDealt);
                Console.WriteLine($"{enemy.Name}이(가) {player.Name}에게 {damageDealt}의 피해를 입혔습니다!");
            }
            else
            {
                Console.WriteLine($"{enemy.Name}의 공격이 {player.Name}에게 효과가 없습니다!");
            }
        }
    }
}