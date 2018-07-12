using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{

     sealed class Singleton
    {
        private static Singleton _instance = null;

        private Singleton()
        {

        }

        public  static Singleton Get_Instance()
        {

            if (_instance == null)
                _instance = new Singleton();

            return _instance;

        }
        
    }
}
