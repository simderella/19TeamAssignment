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

        //장비아이템 장착 시켜주는 함수
        public static void EquipItem()
        {
            
        }
    }

}