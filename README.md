# 19조 2주차 팀과제!

팀구현 목록 설명
1. 아스키아트로 인트로 화면 꾸미기
2. 배경음악을 넣어주기
밑의 줄은 배경음악을 넣은 코드이다.

    WindowsMediaPlayer player = new WindowsMediaPlayer();

   
    ThreadPool.QueueUserWorkItem(_ =>

 
     {
             player.URL = @"https://blog.kakaocdn.net/dn/dMkM1O/btsALLfnxcm/Xbt63bVuFEmLHXhRtBgOh0/dfSeason1.mp3?attach=1&knm=tfile.mp3";
             player.settings.volume = 4;
     });

 ------
4. 상태보기
   이름을 지어줄 수 있고 원하는 직업을 선택할 수 있다.
   ------
5. 인벤토리
   아이템 목록과 장착관리를 통해 아이템을 장착하여 스탯을 올려줄 수 있다.
   -------
6. 던전가기
   던전에서는 랜덤한 수의 몬스터가 등장하게 되고, 플레이어의 스탯에 따라 전투를 진행한다.
   몬스터마다 체력과 공격력을 다르게 설정해주었고, 플레이어의 방어력만큼 몬스터의 공격력을 무시할 수 있도록 만들어주었다.
   추가로 도망가기 기능을 만들어서 50퍼센트의 확률로 마을로 돌아갈 수 있다.

