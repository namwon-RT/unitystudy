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

            //while(a < 5 /*조건*/) // 조건이 참이라면 실행하고 다시 돌아와서 조건을 확인한다를 반복
            //{
            //    Console.WriteLine("무한반복");
            //    a++;
            //}

            /*
            정수 변수 num을 1로 초기화한다.
            while문을 이용해 1부터 10까지 출력한다
            출력 후 num을 1씩 증가시킨다
            */
            int num = 1;
            while (num < 11)
            {
                Console.WriteLine(num);
                num++;
            }
        }
    }
}
