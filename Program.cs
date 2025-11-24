namespace unitystudy
{
    internal class Program
    {
              
        static void Main(string[] args)
        {
            //// 반복문

            //// while
            //// dowhile
            //// for
            //int a = 0;

            //while(a < 5 /*조건*/) // 조건이 참이라면 아래 명령문을 실행하고 다시 돌아와서 조건을 확인한다를 반복
            //{
            //    Console.WriteLine("무한반복");
            //    a++;
            //}

            /*
            정수 변수 num을 1로 초기화한다.
            while문을 이용해 1부터 10까지 출력한다
            출력 후 num을 1씩 증가시킨다
            */
            //int num = 1; //초기화
            //while (num < 11) //조건
            //{
            //    Console.WriteLine(num);
            //    num++; //조건변경 //++num도 차이가 없다. 해당줄 다음에 다른 명령어가 없고 끝났으므로.
            //}

            //for(int num2 = 1; num2 < 11; num2++) //조건자리가 비어져있으면 true로 인식한다 for(; ;) 이것도 가능
            //{
            //    Console.WriteLine(num2);
            //}
            for (int n =0; n < 9; n++)
            {
                for(int m = 0; m < 9; m++)
                {
                    Console.WriteLine($"{n} {m}");
                }
                 
            }

            ////dowhile문
            //do //do 밑의 명령을 무조건 1번은 실행하고 while 조건이 참일경우 반복한다.while과 똑같으나 무조건 1번은 실행된다는점만 다르다.
            //{
            //    Console.WriteLine(num);
            //    ++num;
            //} while (num < 11);

            // for문
            // for (초기화; 조건; 조건변경)

        }
    }
}
