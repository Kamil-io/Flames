using System;

namespace Flames
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name1 = args[0];
            string name2 = args[1];
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
            string stringholder = repeat(flames, 26);

            for (int i = 0; i < 5; i++)
            {
                string toRemove = stringholder[cutOffnumber - 1].ToString();
                stringholder = stringholder.Substring(cutOffnumber).Replace(toRemove, "");
            }
            Console.WriteLine(stringholder[0]);
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
