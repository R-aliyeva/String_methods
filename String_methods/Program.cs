using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace String_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //  char[] chars = { '#','a' };

            // Console.WriteLine(input.Trim(chars));

            //TrimStart(input, 'l');
            TrimEnd(input, 'l');
        }
        public static void TrimStart(string input, char ch)
        {
            int leng = input.Length;
            for (int i = 0; i < input.Length; i++)
            {
              
                char ch2 = input[i];
                if (ch2 == ch)
                {


                    int ind = input.IndexOf(ch2);
                    input = input.Substring(ind, leng - ind);
                }
                else
                {
                    int ind = input.IndexOf(ch2);
                    input = input.Substring(ind, leng - ind);
                    break;
                }




                }
     
            
            Console.WriteLine(input);


        }
        public static void TrimEnd(string input, char ch)
        {
            int leng = input.Length;
            for (int i = leng-1; i >0; i--)
            {

                char ch2 = input[i];
                if (ch2 == ch)
                {


                    int ind = input.IndexOf(ch2);
                    input = input.Substring(0, leng-ind);
                }
                else
                {
                    int ind = input.IndexOf(ch2);
                    input = input.Substring(0,leng- ind);
                    break;
                }




            }


            Console.WriteLine(input);


        }
    }
}
