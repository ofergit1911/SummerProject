using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        //פעולה שמגדירה את גודל המסך להיו 7 אינץ
        static void SetLargeSize(Phone x)
        {
            x.SetScreenSize(7);
        }

        static Phone CreatePhone()
        {
            Phone x = new Phone("Microsoft");

            return x;
        }

         static void Main(string[] args)
        {
            //  int x=5;
            //            Rect r = new Rect(5, 6);
            //            Console.WriteLine(r.Area());

            // Phone myPhone = Phone.NewInstance();

            Console.WriteLine("Enter Manfucaturer");
            String manf = Console.ReadLine();
            Console.WriteLine("Enter Screen Size");
            double size = double.Parse(Console.ReadLine());

            Phone byUser = new Phone(size, manf);

            Phone p = new Phone(4.5, "apple");
             Phone a = new Phone("LG");
            Phone mem = new Phone(7, "Google", 32);
            int currentMemory = mem.GetMemory();
            mem.SetMemory(currentMemory + 32);

            Phone.CanTalk();



            SetLargeSize(a);
            Console.WriteLine(a.GetScreenSize());

            Phone ms = CreatePhone();
            Console.WriteLine(ms.GetManufacturer());
            int x = Math.Abs(-1);

        }
    }
}























/*
 *             int rows = 2;
            int lines = 13;

            //Bi dimensional array of all english characters
            char[,] tavim = new char[lines, rows];
            char firstTav = 'a';

            //Initalize
            for (int i=0; i < tavim.GetLength(0); i++)
            {
                for (int j = 0; j < tavim.GetLength(1); j++)
                {
                    tavim[i, j] = firstTav;
                    firstTav++;
                }
            }

            //Print
            for (int i = 0; i < tavim.GetLength(0); i++)
            {
                for (int j = 0; j < tavim.GetLength(1); j++)
                {
                    Console.Write("{0} ",tavim[i, j]);
                }
                Console.WriteLine("");
            }
*/