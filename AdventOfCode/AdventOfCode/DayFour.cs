using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace AdventOfCode
{
    class DayFour
    {
        static string input = "iwrupvqb";

        public static void Run()
        {
            PartOne();
            PartTwo();
            
        }

        static void PartOne()
        {
            
            int answer = 1;
            while(CalculateMD5Hash(input + answer).Substring(0,5) != "00000")
            {
                answer++;
            }
            Console.WriteLine($"Day 4 Part One Answer : {answer}");

        }

        static void PartTwo()
        {

            int answer = 1;
            while (CalculateMD5Hash(input + answer).Substring(0, 6) != "000000")
            {
                answer++;
            }
            Console.WriteLine($"Day 4 Part 2 Answer : {answer}");
        }

        static string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

    }

}
