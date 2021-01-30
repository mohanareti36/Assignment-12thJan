using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcpt
{
    class Program
    {

        public static int comp(string s1, string s2)
        {
            int v=s1.CompareTo(s2);
            return v;
        }
        /*public static string Rev(string s)
        {
            //if (s.Length == 1) return s;

        }*/
    }
        class Logic
       {
        static void Main(string[] args)
        {
           string rev(string s)
            {
                if (s.Length == 1)
                    return s;
                int l = s.Length - 1;
                string s1 = "";
                while(l>=0)
                {
                    s1 = s1 + s[l];
                    l--;
                }
                return s1;
            }
            string str = "mohan";
            string str1 = "kumar";
            int r;
            Console.WriteLine("---> Welcome to String Methods Demo <---");
            Console.WriteLine("1. To Compare Strings press-1");
            Console.WriteLine("2. To Concat the Strings press-2");
            Console.WriteLine("3. To Reverse a String press-3");
            Console.WriteLine("4. To Replace a String press-4");
            Console.WriteLine("5. To a Split a String press-5");
            Console.WriteLine("6. To find the Length of the string press-6");
            //Console.WriteLine(String.Compare(str,str1));
            r = Convert.ToInt32(Console.ReadLine());
            switch (r)
            {
                case 1:
                    Console.WriteLine("Enter string 1: ");
                    str = Console.ReadLine();
                    Console.WriteLine("Enter string 2: ");
                    str1 = Console.ReadLine();
                    int v = Program.comp(str, str1);
                     if (v == 0)
                    Console.WriteLine("The two Strings are equal");
                    else
                    Console.WriteLine("The two Strings are NOt equal");
                    break;
                case 2:
                    Console.WriteLine("Enter string 1: ");
                    str = Console.ReadLine();
                    Console.WriteLine("Enter string 2: ");
                    str1 = Console.ReadLine();
                    Console.WriteLine("The String after Concatenating : " + String.Concat(str, str1));
                    break;
                case 3:
                    Console.WriteLine("Enter a string to reverse: ");
                    str = Console.ReadLine();
                    Console.WriteLine("Reversed String : " + rev(str));
                    break;
                case 4:
                    Console.WriteLine("Enter the string : ");
                    str = Console.ReadLine();
                    Console.WriteLine("What do you want to be replaced in the above string? ");
                    str1 = Console.ReadLine();
                    Console.WriteLine("With what do you want it to be replaced ? ");
                    string str2 = Console.ReadLine();
                    string str3 = str.Replace(str1, str2);
                    Console.WriteLine("Before : " + str);
                    Console.WriteLine("After  : " + str3);
                    break;
                case 5:
                    Console.WriteLine("Enter a string : ");
                    str = Console.ReadLine();
                    Console.WriteLine("Kindly enter where to split the given string : ");
                    char tempChar = Console.ReadLine()[0];
                    string[] sArray = str.Split(tempChar);
                    Console.WriteLine("After Split: ");
                    foreach (String s in sArray)
                    {
                        Console.WriteLine(s );
                    }
                    Console.WriteLine();
                    break;
                case 6:
                    Console.WriteLine("Enter a string to find length :");
                    str = Console.ReadLine(); ;
                    Console.WriteLine("Length of the string : " + str.Length);
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;

            }
            

        }
    }
}
