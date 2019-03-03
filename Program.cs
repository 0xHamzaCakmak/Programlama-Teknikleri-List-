using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_list_string_karakter_bulma
{
    class Program
    {
        static List<string> Kontrol(string s, char c)
        {
            List<string> str = new List<string>();
            for (int i = 0; i < s.Length; i++ )
            {
                if (s[i] == c)
                { str.Add(i.ToString()); }
            }
            return str;
        }
        static void yaz(List<string>s)
        {
            foreach (object o in s)
                Console.Write(" " + o);
        }
        static void Main(string[] args)
        {
            string s = "badana";
            char c = 'a';
            yaz(Kontrol(s, c));
        }
    }
}
