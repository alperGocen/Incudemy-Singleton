using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Get_Instance();
            Singleton s2 = Singleton.Get_Instance();


            if (s1.Equals(s2))
                Console.WriteLine("The instances are the same!!");
            else
                Console.WriteLine("The instances are different");
            
            Console.ReadKey();
        }
    }
}
