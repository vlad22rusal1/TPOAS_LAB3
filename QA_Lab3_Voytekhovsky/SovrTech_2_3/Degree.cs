using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


namespace SovrTech_2_3
{

    public class Degree
    {
        private int degree;
        private int min;
        private int sec;

        public int Sec { 
            get
            {
                return sec;
            }
            set
            {
                if (value >= 0 && value < 60)
                {
                    sec = value;
                }
            }
        }
        public void Init(int d, int m, int s)
        {
            degree = d;
            min = m;
            sec = s;
        }
        public void Display()
        {
            string s0, s1, s2, full;
            s0 = Convert.ToString(degree);
            s1 = Convert.ToString(min);
            s2 = Convert.ToString(sec);
            full = "Градусы :"+s0+" Минуты :" + s1 +" Секунды :"+ s2;
            Console.WriteLine(full);
        }
        public void Read()
        {
            string s = "";
            s = Console.ReadLine();
            string[] s1;
            s1 = s.Split(new char[] { ' ', '\t' });
            degree = Convert.ToInt32(s1[0]);
            min = Convert.ToInt32(s1[1]);
            sec = Convert.ToInt32(s1[2]);
        }
        public int Rounding()
        {
            if (sec > 30)
            {
                min += 1;
            }
            if (min > 30)
            {
                degree += 1;
            }
            return degree;
        }
        public int Ndegree()
        {
            return degree;
        }
        public  Degree Add(Degree a, Degree b)
        {
            Degree sum;
            sum = new Degree();
            int k1, k2;
            sum.degree = a.degree+b.degree;
            k1 = a.min + b.min;
            k2 = a.sec + b.sec;
            if (k2 >= 60)
            {
                k1++;
                k2 = k2 - 60;
            }
            sum.sec = k2;
            if (k1 >= 60)
            {
                sum.degree++;
                k1=k1 - 60;
            }
            sum.min = k1;
            return sum;
        }
    }
}
