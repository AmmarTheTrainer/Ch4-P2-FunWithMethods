using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_P2_FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Ch 4 - project 2 - Methods\n");

            #region - 1 - Pass two variables in by value

            //int x = 9, y = 10;
            //Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
            //Console.WriteLine("Answer is: {0}", Add(x, y));
            //Console.WriteLine("After call: X: {0}, Y: {1}", x, y);

            #endregion

            #region - 2 - use out modifier in C# Methods


            // No need to assign initial value to local variables
            // used as output parameters, provided the first time
            // you use them is as output arguments.
            // C# 7 allows for out parameters to be declared in the method call
            //int ans;
            //Add(90, 90, out ans);
            ////Add(90, 90, out int ans); // in C# 7
            //Console.WriteLine("90 + 90 = {0}", ans);

            //int i; string str; bool b;
            //FillTheseValues(out i, out str,out b);
            //Console.WriteLine("Int is: {0}", i);
            //Console.WriteLine("String is: {0}", str);
            //Console.WriteLine("Boolean is: {0}", b);

            //int a;
            //ThisWontCompile(out a);
            ////ThisWontCompile(out _); // if you don't need this value , use discard

            #endregion

            #region - 3 - ref Modifer in C#

            //string str1 = "Flip";
            //string str2 = "Flop";

            //Console.WriteLine("Before: {0}, {1} ", str1, str2);
            //SwapStrings(ref str1, ref str2);
            //Console.WriteLine("After: {0}, {1} ", str1, str2);

            int a = 1;
            int b = 2;

            Console.WriteLine("Before: {0}, {1} ", a, b);
            SwapStrings(ref a, ref b);
            Console.WriteLine("After: {0}, {1} ", a, b);

            #endregion

            Console.ReadLine();
        }
        // Reference parameters.
        public static void SwapStrings(ref int no1, ref int no2)
        {
            int tempNo = no1;
            no1 = no2;
            no2 = tempNo;
        }

        // Reference parameters.
        public static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }

        static void ThisWontCompile(out int a)
        {
            Console.WriteLine("Error! Forgot to assign output arg!");
            a = 10; // if you delete this line , there will be an error
        }

        // Returning multiple output parameters.
        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string.";
            c = true;
        }

        // Output parameters must be assigned by the called method.
        static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }

        // Arguments are passed by value by default.
        static int Add(int x, int y)
        {
            int ans = x + y;
            // Caller will not see these changes
            // as you are modifying a copy of the
            // original data.
            x = 10000;
            y = 88888;
            return ans;
        }
    }
}
