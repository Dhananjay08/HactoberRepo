﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_Project.CodeForces
{
    class StructuralDesignPattern   
    {
        class MainApp
        { 
            static void Main()
            {
                Singleton s1 = Singleton.Instance();
                Singleton s2 = Singleton.Instance();
                if (s1 == s2)
                {
                    Console.WriteLine("Objects are the same instance");
                }
                Console.ReadKey();
            }
        }

        class Singleton
        {
            private static Singleton _instance;
            protected Singleton()
            {
            }
            public static Singleton Instance()
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
    }
}