namespace C_GitTestCoumit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. pineapple si yammy
            string Text1 = "pineapple is yammy";
            string Text2 = "apple";

            string searchText = "a";
            if (Text2.IndexOf(searchText) == 0)
            {
                searchText = "-1";
            }
            Console.WriteLine(Text2.IndexOf(searchText));

            // 2. 문자열을 입력받으면 단어의 개수를 출력하기
            int A = 1;

            string str = Console.ReadLine();


            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    A++;
                }
            }
            Console.WriteLine(A);

            // 3. 주어진 숫자가 소수인지 판별하는 solution을 완성하라

            static bool IsPrime(int n)
            {
                int number = int.Parse(Console.ReadLine());

                bool minority = true;


                if (number == 2)
                {
                    minority = true;
                }
                else if (number % 2 == 0)
                {
                    minority = false;
                }
                else
                {
                    for (int i = 3; i < number; i++)
                    {
                        if (i % number == 0)
                        {
                            minority = false;
                            break;
                        }
                        else minority = true;
                    }
                }
                if (minority = true)
                {
                    Console.WriteLine("소수입니다.");
                }
                else
                {
                    Console.WriteLine("소수가아닙니다.");
                }
                return minority;
            }

            // 4.





        }
    }
}