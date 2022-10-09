using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_1_1_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = -2345;
            //long transf_a = a;
            //Console.WriteLine(transf_a);

            //byte b = 255;
            //ushort transf_b = b;
            //Console.WriteLine(transf_b);

            //sbyte c = -128;
            //short transf_c = c;
            //Console.WriteLine(transf_c);

            //long d = -234356789;
            //double transf_d = d;
            //Console.WriteLine(transf_d);

            //ushort e = 65500;
            //uint transf_e = e;
            //Console.WriteLine(transf_e);



            //double a1 = -23.45;
            //int transf_a1 = (int)a1;
            //Console.WriteLine(a1.GetType());
            //Console.WriteLine(transf_a1.GetType());

            //ulong b1 = 365;
            //byte transf_b1 = (byte)b1;
            //Console.WriteLine(b1.GetType());
            //Console.WriteLine(transf_b1.GetType());

            //sbyte c1 = -128;
            //ushort transf_c1 = (ushort)c1;
            //Console.WriteLine(c1.GetType());
            //Console.WriteLine(transf_c1.GetType());

            //long d1 = -234356789;
            //int transf_d1 = (int)d1;
            //Console.WriteLine(d1.GetType());
            //Console.WriteLine(transf_d1.GetType());

            //ushort e1 = 65500;
            //short transf_e1 = (short)e1;
            //Console.WriteLine(e1.GetType());
            //Console.WriteLine(transf_e1.GetType());

            //пустая и null строки
            string empty_str = "";
            string null_str = null;

            Console.WriteLine(String.IsNullOrEmpty(empty_str));
            Console.WriteLine(String.IsNullOrEmpty(null_str));

            string some_str = "Hello world";
            string modified_str = some_str + empty_str;
            Console.WriteLine(modified_str);
            modified_str = some_str + null_str;
            Console.WriteLine(modified_str);

            Console.WriteLine(empty_str == null_str);

            Console.WriteLine(some_str.Length);
            //Console.WriteLine(null_str.Length); вызовет ошибку

            StringBuilder str_bldr = new StringBuilder("apple, orange, tomato, banana", 50);
            Console.WriteLine(str_bldr.ToString());
            str_bldr.Remove(15, 8);
            Console.WriteLine(str_bldr.ToString());

            str_bldr.Append(" etc.");
            Console.WriteLine(str_bldr);

            str_bldr.Insert(0, "Fruits: ");
            Console.WriteLine(str_bldr);
        }
    }
}
