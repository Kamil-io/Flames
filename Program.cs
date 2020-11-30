using System;
using System.Collections.Generic;

namespace Flames
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name1 = "Qwerasdfzxcv";
            string name2 = "Yuiopghjklvbnm";
            char[] name1Array = name1.ToLower().ToCharArray();
            char[] name2Array = name2.ToLower().ToCharArray();
            for (int i = 0; i < name1Array.Length; i++)
            {
                for (int j = 0; j < name2Array.Length; j++)
                {
                    if (name1Array[i] == name2Array[j])
                    {
                        name1Array[i] = '0';
                        name2Array[j] = '0';
                        break;
                    }
                }
            }
            name1 = "";
            name2 = "";
            foreach (var item in name1Array)
            {
                if (item != '0')
                {
                    name1 = name1 + item;
                }
            }
            foreach (var item in name2Array)
            {
                if (item != '0')
                {
                    name2 = name2 + item;
                }
            }
            string finalString = name1 + name2;
            string flames = "FLAMES";
            int cutOffnumber = finalString.Length;
            int removeCharIndex;
            string firstHalf, secondHalf;
            for (int i = 6; i > 1; i--)
            {
                removeCharIndex = (cutOffnumber % i);
                if(removeCharIndex > 0)
                {
                    Console.WriteLine($"Character to be removed {flames[removeCharIndex - 1]}");
                    firstHalf = flames.Substring(0, removeCharIndex - 1);
                    secondHalf = flames.Substring(removeCharIndex);
                    flames = secondHalf + firstHalf;
                    Console.WriteLine($"Remaining characters {flames}");
                }
                else
                {
                    Console.WriteLine($"Character to be removed {flames[flames.Length -1]}");
                    flames = flames.Substring(0, flames.Length - 1);
                    Console.WriteLine($"Remaining characters {flames}");
                }
                
            }
            Console.ReadLine();
        }

        public static string repeat(string targetstring, int nooftimes)
        {
            string tmp = "";
            for (int i = 0; i < nooftimes; i++)
            {
                tmp += targetstring;
            }
            return tmp;
        }

    }
}
