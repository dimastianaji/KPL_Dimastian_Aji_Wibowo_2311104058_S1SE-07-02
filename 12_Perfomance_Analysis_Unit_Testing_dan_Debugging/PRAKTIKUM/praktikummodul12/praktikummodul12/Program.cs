﻿namespace praktikummodul12
{
    public class Program
    {
        public static void Main()
        {
            string result = DetermineGrade(90);
            Console.WriteLine(result);
        }
        public static String? DetermineGrade(int score)
        {
            Dictionary<int, String> GradeMap = new Dictionary<int, String>()
            {
                {90, "A"},
                {80, "B"},
                {70, "C"},
                {60, "D"},
                {0, "E"}
            };
            foreach(var kv in GradeMap.OrderByDescending(kv => kv.Key))
            {
                if(score >= kv.Key)
                {
                    return kv.Value;
                }
            }
            return null;
        }
    }
}