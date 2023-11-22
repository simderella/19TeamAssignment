namespace _19teamGroupAssignment
{
    public static class Inventory
    {     

        public static void DisplayInventory()
        {
            Console.Clear();

            Console.WriteLine("인벤토리-장착관리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine("");
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine("");
            for (int i = 0; i < Character.items.Count; i++) //모든 아이템들을 보여준다.
            {
                Console.WriteLine($"{i + 1}. {Character.items[i].Name}"); //i가 0부터니깐 숫자는 +1을 해서 "1.무딘 검" 이렇게 숫자가 나오게 해준다.
            }

            Console.WriteLine("");
            Console.WriteLine("0. 나가기");

            int input = InputValidator.CheckValidInput(0, Character.items.Count);
            switch (input)
            {
                case 0:
                    GameIntro.DisplayIntro();
                    break;
                default:
                    // 선택한 아이템을 착용
                    InputValidator.EquipItem(Character.items[input - 1]);
                    break;
            }

        }
    }

    
}
