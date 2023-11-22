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
        public static void EquipItem(Item item)
        {          
            

        }



        // 여기부터는 인벤토리 글자간격 조절하는 메서드들.
        public static int GetPrintableLength(string str)
        {
            int length = 0;
            foreach (char c in str)
            {
                if (char.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.OtherLetter)
                {
                    length += 2; // 한글과 같은 넓은 문자에 대해 길이를 2로 취급
                }
                else
                {
                    length += 1; // 나머지 문자에 대해 길이를 1로 취급
                }
            }

            return length;
        }

        public static string PadRightForMixedText(string str, int totalLength)
        {
            int currentLength = GetPrintableLength(str);
            int padding = totalLength - currentLength;
            return str.PadRight(str.Length + padding);
        }
    }

}