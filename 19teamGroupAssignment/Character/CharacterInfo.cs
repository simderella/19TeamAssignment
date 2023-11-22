namespace _19teamGroupAssignment
    {

    public class CharacterInfo
    {
        public Character character;

        public CharacterInfo(Character character)
        {
            this.character = character;
        }

        public void DisplayMyInfo(string info)//뒤에 매게변수가 없다면 매게변수 칸에 ""을 넣어주면 됨.
        {

            Console.Clear();
            Console.WriteLine(info);
            Console.WriteLine("상태 보기");
            Console.WriteLine("캐릭터의 정보를 표시합니다.");
            Console.WriteLine();
            Console.WriteLine($"Lv.{character.Level}");
            Console.WriteLine($"{character.Name}({character.Job})");
            Console.WriteLine($"공격력 :{character.Atk}");
            Console.WriteLine($"방어력 : {character.Def}");
            Console.WriteLine($"체력 : {character.Hp}");
            Console.WriteLine($"Gold : {character.Gold} G");
            Console.WriteLine();
            Console.WriteLine("0. 나가기");

            int input = InputValidator.CheckValidInput(0, 0);
            switch (input)
            {
                case 0:
                    GameIntro.DisplayMain();
                    break;
            }

        }


    }

}






