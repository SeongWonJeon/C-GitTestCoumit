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
        }
    }
}