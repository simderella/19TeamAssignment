using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RtanGame;

namespace _19teamGroupAssignment
{


    internal class Program
    {

    }

        //static int CheckValidInput(int min, int max) 민규님꺼
        //{
        //    while (true)
        //    {
        //        string input = Console.ReadLine();

        //        bool parseSuccess = int.TryParse(input, out var ret);
        //        if (parseSuccess)
        //        {
        //            if (ret >= min && ret <= max)
        //                return ret;
        //        }

        //        Console.WriteLine("잘못된 입력입니다.");
        //    }
        //}
        // 테스트용으로 제꺼 쓰던거에서 가져왔습니다 결과창으로 쓰기 좋을 것 같아서요

        //        static void StartDungeon(Dungeon dungeon)
        //        {
        //            Console.Clear();
        //            Console.WriteLine($"당신은 {dungeon.Name}에 입장했습니다.");

        //            Battle battle = new Battle(player, dungeon.Monster);
        //            battle.StartBattle();

        //            if (player.IsAlive)
        //            {
        //                Console.WriteLine($"던전을 클리어했습니다! 획득한 골드: {dungeon.Monster.Gold}");
        //                player.Gold += dungeon.Monster.Gold;
        //            }
        //            else
        //            {
        //                Console.WriteLine("던전에서 패배했습니다. 게임 오버!");
        //                Console.WriteLine("아무 키나 누르면 계속하세요...");
        //                Console.ReadKey();
        //                DisplayGameIntro(); // 게임 오버 시 메뉴로 돌아감
        //            }

        //            Console.WriteLine("아무 키나 누르면 계속하세요...");
        //            Console.ReadKey();
        //            DisplayGameIntro();
        //        }
        //    }
        //}
 }
