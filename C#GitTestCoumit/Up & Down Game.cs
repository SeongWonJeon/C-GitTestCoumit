using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_GitTestCoumit
{
    internal class Up___Down_Game
    {
        public static void UpDownGame()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            int GuessNumber = 0;
            int tries = 1;

            Console.WriteLine("Up&DownGame에 오신것을 환영합니다.");
            Console.WriteLine("추측한 숫자가 무엇인가요?");
            while (tries < 11 && GuessNumber != randomNumber)
            {
                Console.Write("숫자를 맞춰주세요 : ");
                GuessNumber = int.Parse(Console.ReadLine());

                if (GuessNumber < randomNumber)
                {
                    Console.WriteLine("Up!");
                }
                else if (GuessNumber > randomNumber)
                {
                    Console.WriteLine("Down!");
                }

                if (GuessNumber != randomNumber)
                {
                    Console.WriteLine("남은10회 중 {0}회 사용하였습니다.", tries);
                }
                tries++;
            }
            if(GuessNumber == randomNumber)
            {
                Console.WriteLine("축하합니다!! 맞췄습니다!!");
            }
            else
            {
                Console.WriteLine("기회를 모두 소진하였습니다.");
            }
            Console.WriteLine();
            
        }
    }
}
