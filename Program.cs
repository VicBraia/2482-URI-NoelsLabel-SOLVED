using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        public static int M, N;
        public static Dictionary<String, String> tabLang = new Dictionary<string, string>();
        public static List<String> childNames = new List<string>();
        public static List<String> childLang = new List<string>();

        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string language = Console.ReadLine();
                string merryChristmas = Console.ReadLine();
                tabLang.Add(language, merryChristmas);
            }
            M = int.Parse(Console.ReadLine());
            for (int i = 0; i < M; i++)
            {
                string name = Console.ReadLine();
                string language = Console.ReadLine();
                childNames.Add(name);
                childLang.Add(language);
            }


            for (int i = 0; i < childNames.Count; i++)
            {
                string merryChristmas;
                string key = childLang[i];
                if (tabLang.TryGetValue(key, out merryChristmas))
                {
                    Console.WriteLine(childNames[i]);
                    Console.WriteLine(merryChristmas);
                    Console.WriteLine();
                }
            }
        }
    }
}
