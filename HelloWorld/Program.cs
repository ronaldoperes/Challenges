using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
          var str = Kata.greet();
          Console.WriteLine(str);

          var str2 = Kata.greet2();
          Console.WriteLine(str2);
        }
    }

    public static class Kata
    {
        // Write a public static method "greet" that returns "hello world!"

        public static string greet() => "hello world!";

        public static string greet2()
        {
            return "hello world!";
        }
    }
}
