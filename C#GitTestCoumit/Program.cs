namespace C_GitTestCoumit
{
    internal class Program
    {
        public static int[] FindCommonItem(int[] arr1, int[] arr2, int[] arr3)
        {
            int[] ALine = new int[Math.Min(Math.Min(arr1.Length, arr2.Length),arr3.Length)];
            int idx = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        for (int k = 0; k < arr3.Length; k++)
                        {
                            if (arr3[k] == arr1[i])
                            {
                                ALine[idx++] = arr1[i];
                                break;
                            }
                        }
                    }
                    break;
                }
            }
            Array.Resize(ref ALine, idx);
            return ALine;
        }
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

            // 4. 사용자가 입력한 양의 정수의 각 자리수의 합을 구하는 Solution을 완성하라.
            static int SimOfDigits(int num)
            {
                Console.WriteLine("숫자를 입력하세요 : ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}을 전부 분리하여 더하겠습니다.", number);
                int Addnumber = 0;

                char[] A = number.ToString().ToCharArray();


                foreach (char B in A)
                {
                    Addnumber += System.Convert.ToInt32(B.ToString());
                }

                Console.WriteLine(Addnumber);
                return Addnumber;
            }

            // 5. k개의 정렬된 배열에서 공통항목을 찾는 Solution을 완성하라.단, 중복은 허용하지 않는다.
            int[] array1 = { 1, 5, 5, 10 };
            int[] array2 = { 3, 4, 5, 5, 10 };
            int[] array3 = { 5, 5, 10, 20 };
            int[] Ga = FindCommonItem(array1, array2, array3);

            foreach (int i in Ga)
            {
                Console.WriteLine(i);
            }

            // 6. Up___Down_Game 만들기
            Up___Down_Game.UpDownGame();
        }
    }
}