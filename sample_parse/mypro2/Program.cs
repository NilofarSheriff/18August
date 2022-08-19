using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mypro2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region type

            //bool res, vir;
            //int a;
            //string s = "hrllo";
            //vir = int.TryParse(s, out a);
            //Console.WriteLine(vir);
            //double d1;
            //string s1 = "12";
            //res = double.TryParse(s1, out d1);
            //Console.WriteLine(res);
            //Console.ReadLine();
            //Console.WriteLine("------------------------------------------------------");
            //object obj = new object();
            //Type t1 = obj.GetType();
            //Console.WriteLine(t1.Name);
            //Console.WriteLine(t1.FullName);
            //t1 = t1.BaseType;
            //Console.WriteLine(t1.Name);
            //Console.WriteLine(t1.FullName);
            //Console.WriteLine(t1.Namespace);
            //Console.ReadLine();
            #endregion

            //float f1 = 3.14f;
            //double d = f1;
            //Console.WriteLine(d);


            //int i = 10;
            //string s = i.ToString();
            //Console.WriteLine(s);

            //object obj = s;
            //Console.WriteLine(obj);

            int i = 90;
            object o = "90";
           
            bool res = o.Equals(i);
            Console.WriteLine(res);
            Console.ReadLine();



        }
    }
}
