﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5
{
    class Man
    {
        public static string name;
        public int age;
        public float weight;
    }
    class Person
    {
        static void Main(string[] args)
        {
            Man m1 = new Man();
            Man.name = "KBS-1";
            m1.age = 22;
            m1.weight = 55.5F;
            Console.WriteLine("{0},{1},{2}",Man.name,m1.age,m1.weight);
        }
    }
}
