using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SovrTech_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;
            Degree prop = new Degree();
            prop.Sec = 36;
            prop.Sec = 134;//prop.Sec осталось = 36
            Degree a = new Degree();
            a.Init(58, 31, 36);
            a.Display();
            r=a.Rounding();
            Console.WriteLine("Градус после округления = "+r);
            Console.WriteLine("\t");
            Degree b = new Degree();
            b.Read();
            b.Display();
            Console.WriteLine("\t");
            int i, j;
            Degree[] ms;
            ms = new Degree[3];
            for (i = 0; i < 2; i++)
            {
                ms[i] = new Degree();
            }

            ms[0].Init(190, 15, 23);
            ms[0].Display();
            ms[1].Init(190, 15, 20);
            ms[1].Display();
            
            Console.WriteLine("\t");
            Degree add =    new Degree();
            ms[2] = add.Add(ms[0], ms[1]);
            Console.WriteLine("Сложение градусов:");
            ms[2].Display();
            int[] c = new int[3];
            for (i = 0; i < 2; i++)
            {
                c[i] = ms[i].Ndegree();
            }
            j = 0;
            for(i=0; i<2; i++)
            {
                j += c[i];
            }
            Console.WriteLine(Convert.ToString(j));
            Console.ReadKey();
        }
    }
}