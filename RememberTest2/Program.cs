using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RememberTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nontype();
            //MasObjIdent();
            //MasMultyArray();
            //PassAndReciveArrays();
            AriphProgr();

            Console.ReadLine();

        }
        static void Nontype()
        {
            var a = new[] { 1, 2, 3, 4 };

            foreach (int i in a)
                Console.WriteLine(i);
            Console.WriteLine(a.Length);
        }
        static void MasObjIdent()
        {

            object[] objects = new object[4];
            objects[0] = 10;
            objects[1] = false;
            objects[2] = new DateTime(1989, 10, 07);
            objects[3] = "Maksym Ivanov";

            foreach (object obj in objects)
            {
                Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
            }

        }
        static void MasMultyArray()
        {
            int[][] myJagArray = new int[5][];
            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int[i + 1];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                    Console.Write(myJagArray[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        ///
        static void PrintArray(int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
                Console.WriteLine("Item {0} is {1}", i, myInts[i]);
        }
        static string[] GetStringArray()
        {
            string[] theStrings = { "Hello", "from", "GetStringArray" };
            return theStrings;
        }
        static void PassAndReciveArrays()
        {
            Console.WriteLine("=> Arrays as params and return values.");
            //peredat massiv
            int[] ages = { 20, 22, 23, 24, 0 };
            PrintArray(ages);
            //give array
            string[] strs = GetStringArray();
            foreach (string s in strs)
                Console.WriteLine(s);
            Console.WriteLine();
        }
        ///

        static void AriphProgr()
        {
            int a = 2; //то, что будем возводить в степень
            int n = 5; //сколько элементов в формуле (сколько итераций)
            int mult = n - 1; //размер степени 
            int x; //вычисленная степень

            for (int i=0; i<=mult; i++)
            {
                x = Convert.ToInt32(Math.Pow(a, mult));

                //for (int j = 0; j <= mult; j++)
                //  {
                //       Console.WriteLine(1 + (x));
                //    }
                Console.WriteLine(x);

            }


        }
    }
}
