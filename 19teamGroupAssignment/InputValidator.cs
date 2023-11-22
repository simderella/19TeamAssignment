namespace _19teamGroupAssignment
{
    //플레이어가 선택한 숫자가 올바른지 확인하는 함수를 클래스 안에 넣어서 따로 만들어줌.
    //int 변수이름 = InputValidator.CheckValidInput(정수,정수); 형식으로 입력해서 사용.
    public static class InputValidator
    {
        public static int CheckValidInput(int min, int max)
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

        //장비아이템 장착 확인 후 착용
        public static void EquipItem(Item item)
        {


            // 이미 착용한 아이템인지 확인
            if (Character.instance.EquippedItems.Contains(item)) //Character클래스 안에있는 아이템의 장착 표시를 해주어야 한다.//Inventory클래스 안에 표시해주는것을 넣어준다.
            {
                Console.WriteLine($"{item.Name}은(는) 이미 착용한 아이템입니다.");
            }
            else
            {
                // 장비아이템 착용 안했으면 착용
                Character.instance.EquippedItems.Add(item);
                Character.instance.Atk += item.Atk; // 아이템의 공격력을 추가합니다.
                Character.instance.Def += item.Def; // 아이템의 방어력을 추가합니다.
                Console.WriteLine($"{item.Name}을(를) 착용했습니다.");
            }

        }
    }

}