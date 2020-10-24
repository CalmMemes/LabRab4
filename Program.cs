using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab4
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input2.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            int N = Convert.ToInt32(Console.ReadLine());
            String str_all = Console.ReadLine();
            string[] str_elem = str_all.Split(' ');

            float[] mas = new float[N];
            for (int i = 0; i < N; i++)
            {
                mas[i] = Convert.ToSingle(str_elem[i]);
            }

            float pr = 1;
            float sa = 0, s = 0;
            for (int i = 0; i < N; i++)
            {
                if (mas[i] < 50)
                    pr = pr * mas[i];
                s += mas[i];
            }
            sa = 1.0f * s / N;
            if (pr == 1)
                Console.WriteLine(0);
            else 
                Console.WriteLine(string.Format("{0:0.000000}", pr));
            for (int i = 0; i < N; i++)
            {
                if (mas[i] > sa)
                {
                    Console.Write(mas[i] + " ");
                }
            }

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}
