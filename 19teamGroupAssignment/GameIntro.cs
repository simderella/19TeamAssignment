namespace _19teamGroupAssignment
{
    public static class GameIntro
    {
        //CharacterInfo 인스턴스화, 해당 클레스의 함수를 사용하기 위해.
        private static CharacterInfo characterInfo;

        //읽기 전용으로 값을 바꿀수 없게 해줍니다.
        private static readonly string[] jobList = { "전사", "궁수", "도적", "마법사" };

        //게임 시작 인트로 화면입니다.
        public static void DisplayIntro()
        {
            Console.Clear();
            //여기는 아스키아트를 이용하여 인트로 만들기

            Console.WriteLine("1. 게임시작");
            int input = InputValidator.CheckValidInput(1, 1);
            switch (input)
            {
                case 1:
                    CreateNewCharacter();
                    break;

            }
        }


        //메인 화면입니다.
        public static void DisplayMain()
        {

            Console.Clear();

            Console.WriteLine("식구조 마을에 오신것을 환영합니다.");
            Console.WriteLine("이곳에서 던전에 들어가기 전 행동을 선택하여 주세요.");
            Console.WriteLine();
            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 던전가기");
            Console.WriteLine();
            int input = InputValidator.CheckValidInput(1, 3);
            switch (input)
            {
                case 1:
                    characterInfo.DisplayMyInfo("");
                    break;

                case 2:
                    // 인벤토리 작업한거 넣기

                    break;
                case 3:
                    //던전입장
                    break;

            }
        }



        static void CreateNewCharacter()
        {
            Console.Clear();

            Console.WriteLine("새로운 캐릭터를 만듭니다.");
            Console.Write("이름을 입력하세요: ");
            string name = Console.ReadLine();

            // 직업 선택 부분
            Console.WriteLine("직업을 선택하세요:");
            for (int i = 0; i < jobList.Length; i++)//for문으로 직업을 보여줌
            {
                Console.WriteLine($"{i + 1}. {jobList[i]}");
            }
            int jobInput = InputValidator.CheckValidInput(1, jobList.Length);//값이 올바르게 들어갔는지 확인하는 함수.
            string job = jobList[jobInput - 1];//선택한 직업으로 결정

            // 나머지 속성은 기본 값으로 설정
            Character newCharacter = new Character(name, job, 1, 10, 5, 100, 1500);
            characterInfo = new CharacterInfo(newCharacter);



            // 생성된 캐릭터 정보를 표시
            characterInfo.DisplayMyInfo($"캐릭터 {name}({job})가 생성되었습니다.\n");//매게변수를 설정해줘서 캐릭터 생성시에 한번 생성했다는 공지가 올라옵니다.
        }
    }

}