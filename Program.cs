using System;

namespace csharp_new_practice6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            //Console.WriteLine(i++);
            //Console.WriteLine(i++);
            //Console.WriteLine(i++);
            //Console.WriteLine(i++);
           

            i =i++ + i++ + i++ + i;
            Console.WriteLine(i++ + i);
            Console.ReadLine();
        }
    }
}
