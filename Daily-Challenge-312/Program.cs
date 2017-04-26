using System;
using System.Collections.Generic;

namespace DailyChallenge312
{
    class Program
    { 
        static Dictionary<string, string> d = new Dictionary<string, string>()
            {
                { "A", "4" },
                { "B", "6" },
                { "E", "3" },
                { "I", "1" },
                { "M", @"(V)" },
                { "N", @"(\)" },
                { "O", "0" },
                { "S", "5" },
                { "T", "7" },
                { "V", @"\/" },
                { "W", @"`//" }
            };     

        static void Main(string[] args)
        {
            Console.WriteLine(Replace("I am elite."));
            Console.WriteLine(Replace("Da pain!"));
            Console.WriteLine(Replace("Eye need help!"));
            Console.WriteLine(Replace(@"3Y3 (\)33d j00 t0 g37 d4 d0c70r."));
            Console.WriteLine(Replace("1 n33d m4 p1llz!"));

            Console.ReadKey();
        }
        
        static bool IsLeet(string input)
        {
            foreach (KeyValuePair<string, string> kvp in d)
            {  
                if (input.Contains(kvp.Value))
                    return true;
            }

            return false;
        }

        static string Replace(string input)
        {
            if (IsLeet(input))
            {                
                foreach (KeyValuePair<string, string> kvp in d)
                    input = input.ToUpper().Replace(kvp.Value, kvp.Key);
            }
            else
            {
                foreach (KeyValuePair<string, string> kvp in d)
                    input = input.ToUpper().Replace(kvp.Key, kvp.Value);                
            }
            
            return Capitalize(input);
        }

        static string Capitalize(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1).ToLower();

            return str.ToUpper();
        }
    }
}