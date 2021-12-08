using System;
namespace ch5
{
    class Argument
    {
        public static void Main(string[] args)
        {
            for(int i=0;i<args.Length;i++)
            {
                Console.WriteLine("전달된 매개변수 {0} + {1}",i,args[i]);
            }
        }
    }
}