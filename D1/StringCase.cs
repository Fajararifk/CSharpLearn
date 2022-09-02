using System.Text;

namespace D1
{
    internal class StringCase
    {
        public static void StringsCase()
        {
            //substring
            string word = "code academy bootcamp";
            string cutword = word.Substring(5, 7); //5 nya index, 7 nya length
            Console.WriteLine(cutword);
            Console.WriteLine($"kata '{word}' length = {word.Length}");
            Console.WriteLine($"{word.Replace("code","codeid")}");


            String cutAcademy = word.Substring(word.IndexOf("academy"),7);
            Console.WriteLine($"cutAcademy : {cutAcademy}");
        }
        // word = "ABC"
        // output = "CBA"
        public static string ReverseString(string word)
        {
            string reverse = "";
            char[] chars = word.ToCharArray();
            reverse += chars.ElementAt(0);
            reverse += chars.ElementAt(1);
            reverse += chars.ElementAt(2);

            return reverse;
        }

        /*public static StringBuilder ReverseStringBuilder(string word)
        {
            StringBuilder ab = new StringBuilder();
            char[] chars = word.ToCharArray();
            ab.Append(chars.ElementAt(2);
            ab.Append(chars.ElementAt(1);
            ab.Append(chars.ElementAt(0);
            return ab;
        }*/
    }
}