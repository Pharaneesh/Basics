using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace basics.basics
{
    class Program
    {
        static void Main(string[] args)
        {
            ////***************************************console app***********************
            //Console.Write("Hi Pharaneesh!");
            //Console.Write(" welcome to sysveda\n");
            //Console.WriteLine("Hi Pharaneesh");
            //Console.WriteLine("welcome to sysveda");
            //Console.WriteLine("enter your name");
            //string a = Console.ReadLine();
            //Console.WriteLine($"Hi {a}! your employee id is 0673");
            //Console.WriteLine("enter a character");
            //int b = Console.Read();
            //Console.WriteLine($"it will change into ascii:{b}");
            //Console.ReadKey();
            //// -----------------------Special Character------------------------------------
            //string txt = "The character is called \"double quote\" ";
            //Console.WriteLine(txt);
            //string txt2 = "It\'s Single quote.";
            //Console.WriteLine(txt2);
            //string txt3 = "The character \\ is called backslash.";
            //Console.WriteLine(txt3);
            ////------------------------------GET SIZE OF DATATYPES------------------------
            //Console.WriteLine(sizeof(int));
            //Console.WriteLine(sizeof(float));
            //Console.WriteLine(sizeof(long));
            //Console.WriteLine(sizeof(double));
            //Console.WriteLine(sizeof(decimal));
            //Console.WriteLine(sizeof(char));  
            //String  name =  "a";
            //Console.WriteLine(name.Length);
            //Console.WriteLine(sizeof(bool));
            ////---------------------Datatypes-------------------------------------------- -
            //int a = 10;
            //const int b = 10;
            //int c = a + b;
            //Console.WriteLine("Integer " + c);
            //Console.WriteLine(c.GetType());


            //float num1 = 2.34f;
            //float num2 = 5.34f;
            //float num3 = num1 - num2;
            //Console.WriteLine("float " + num3);
            //Console.WriteLine(num3.GetType());

            //long x = 10283465783437;
            //long y = 2384237295849;
            //long z = x * y;
            //Console.WriteLine("long " + z);
            //Console.WriteLine(z.GetType());

            //double l = 2.34;
            //double m = 5.34;
            //double n = l / m;
            //Console.WriteLine("double " + n);
            //Console.WriteLine(n.GetType());

            //char my = 'p';
            //Console.WriteLine(my);
            //Console.WriteLine(my.GetType());

            //string name = "pharaneesh";
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetType());
            //// --------------Assignment operator-------------------------------------
            //int a = 10;
            //a += 2;
            //Console.WriteLine(a);
            //int x = 10;
            //x /= 2;
            //Console.WriteLine(x);

            //int b = 10;
            //b %= 2;
            //Console.WriteLine(b);

            //int c = 10;
            //c -= 2;
            //Console.WriteLine(c);

            //int d = 10;
            //d *= 2;
            //Console.WriteLine(d);
            //int A = 5;
            //A &= 3;
            //Console.WriteLine(A);
            //int B = 5;
            //B |= 3;
            //Console.WriteLine(B);
            //int C = 5;
            //C ^= 3;
            //Console.WriteLine(C);
            //// ------------------------------------Comparision Operator--------------------------------------------
            //int x = 5;
            //int y = 3;
            //Console.WriteLine(x == y);
            //int a = 5;
            //int b = 3;
            //Console.WriteLine(a > b);
            //int c = 5;
            //int d = 3;
            //Console.WriteLine(c < d);
            //int e = 5;
            //int f = 3;
            //Console.WriteLine(e != f);
            //int l = 5;
            //int m = 3;
            //Console.WriteLine(l <= m);
            //int p = 5;
            //int q = 3;
            //Console.WriteLine(p >= q);
            //// ------------------------------------Logical Operator--------------------------------------------
            //int x = 8;
            //Console.WriteLine(x > 3 && x < 10);
            //int y = 8;
            //Console.WriteLine(y > 3 || y < 10);
            //int z = 5;
            //Console.WriteLine(!(z > 3 && z < 10));
            ////----------------------------Ternary  operator--------------------------------------------------------
            //int a=10; int b=5;
            //int c = (a > b) ? a : b;
            //Console.WriteLine(c);
            ////  --------------------------------------------------Implicit------------------------------------------------
            //Console.WriteLine("Implicit");
            //int a = 10;
            //float b = 20.34f;
            Console.WriteLine(name.IndexOf('e'));
            Console.WriteLine(wrd[2]);
            string s1 = "abcdefghijk";
            string s2 = s1.Remove(4, 5);
            Console.WriteLine(s2);
            string wrd2 = wrd.Remove(2);
            Console.WriteLine(wrd2);
            Console.WriteLine(string.Compare(wrd, wrd2));
            Console.WriteLine(name.StartsWith('p'));
            string s3 = "Microsoft";
            Console.WriteLine(s3.Replace('m', 'M'));
            Console.WriteLine(s3.Substring(3));
            string[] s4 = wrd1.Split(' ');
            for (int i = 0; i < s4.Length; i++)
            {
                Console.WriteLine(s4[i]);
            }
            Console.WriteLine(s1.Equals(s2);
            Console.BackgroundColor = ConsoleColor.Black;
            //// -----------------------------------If Conditions---------------------------------- -
            //int a = 10;
            //int b = 20;
            //if (a < b)
            //{
            //    Console.WriteLine("A is bigger than B");
            //}
            //else
            //{
            //    Console.WriteLine("B is bigger than A");
            //}
            //// -------
            //int a = 10;
            //int b = 20;
            //if (a < b)
            //{
            //    Console.WriteLine("A is bigger than B");
            //}
            //else if (a > b)
            //{
            //    Console.WriteLine("B is bigger than A");
            //}
            //else
            //{
            //    Console.WriteLine("Both are Equal");
            //}
            //// -------------Switch Statement------------------------------------------------------
            //int empid = 673;
            //switch (empid)
            //{
            //    case 234:
            //        Console.WriteLine("this not an empid");
            //        break;
            //    case 673:
            //        Console.WriteLine("this is a pharaneesh empid");
            //        break;
            //    case 22:
            //        Console.WriteLine("$$$$$$$$$");
            //        break;
            //    case 34:
            //        Console.WriteLine("fdgsgsgsdg");
            //        break;
            //    default:
            //        Console.WriteLine("looking for the project");
            //        break;
            //}
            //// -----------------Looping statement---------------------------------------- -
            ////  -------for loop----------
            //int i;
            //for (i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //// ---------while loop----------
            //int i = 0;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //// ----------Do while Loop----------
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i <= 10);
            //// ----------for each loop________
            //string[] company = { "sysveda", "zoho", "tcs" };
            //foreach (string i in company)
            //{
            //    Console.WriteLine(i);

            //}
            //// ---------Array----------------
            //string[] emp = { "pharaneesh", "praveen", "prakash" };
            //foreach (string i in emp)
            //{
            //    Console.WriteLine(i);
            //}
            //// ----------Another method-------------- -
            //string[] emp = new string[3] { "pharaneesh", "prakash", "praveen" };
            //foreach (string i in emp)
            //{
            //    Console.WriteLine(i);
            //}
            //// --------another method---------------- -
            //string[] emp = new string[3];
            //emp[0] = "pharaneesh";
            //emp[1] = "praveen";
            //emp[2] = "prakash";
            //foreach (string i in emp)
            //{
            //    Console.WriteLine(i);
            //}
            //// -------------array sort----------------------
            //int[] num = new int[] { 2, 3, 1, 4, 5, 8 };
            //int i;
            //Array.Sort(num);
            //{
            //    for (i = 0; i < num.Length; i++)
            //    {
            //        Console.WriteLine(num[i]);
            //    }
            //}
        }
    }
}
