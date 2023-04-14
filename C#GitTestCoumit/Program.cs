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
            
        }
    }
}