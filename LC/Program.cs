using System;

namespace LC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //var result = PlusOneArray.PlusOne(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });
            //Console.WriteLine(result);
            
            var result2 = PlusOneArray.PlusOne(new int[] { 9, 9, 9 });
            Console.WriteLine(result2);

            var result3 = PlusOneArray.PlusOne(new int[] { 8, 9, 9, 9 });
            Console.WriteLine(result3);


        }
    }
}
