namespace 가위바위보
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //상수, 상수그룹 배움 const enum 공부하기 - 가위바위보 게임에 적용해보기
            Random rand = new Random();
            int comChoice = rand.Next(1, 4);

            Console.WriteLine("===============================================");
            Console.WriteLine("가위 바위 보 게임 (1:가위, 2:바위, 3:보)");
            Console.WriteLine("===============================================");
            Console.Write($"선택하세요 : ");
            string input = Console.ReadLine();


            switch (comChoice)
            {
                case 1:
                    Console.WriteLine("컴퓨터는 가위를 냈습니다.");
                    break;
                case 2:
                    Console.WriteLine("컴퓨터는 바위를 냈습니다");
                    break;
                case 3:
                    Console.WriteLine("컴퓨터는 보를 냈습니다");
                    break;
            }
            int player;
            player = int.Parse(input);


            if ((player == 1 && comChoice == 3) || (player == 2 && comChoice == 1) || (player == 3 && comChoice == 2))
            {
                Console.WriteLine("당신이 이겼습니다!");
            }
            else if (player == comChoice)
            {
                Console.WriteLine("비겼습니다!");
            }
            else if ((player == 1 && comChoice == 2) || (player == 2 && comChoice == 3) || (player == 3 && comChoice == 1))
            {
                Console.WriteLine("컴퓨터가 이겼습니다!");
            }
            if (player > 3 || player <= 0)
            {
                Console.WriteLine("잘못된 입력입니다. 1~3 중 하나만 입력해주세요.");
            }
        }
    }
}
