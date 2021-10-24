using System.Linq;

namespace WebAppCodes.Etc
{
    public static class ExLinq
    {
        public static string BasicAggregate()
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };

            var result = numbers.Aggregate((x, y) => x + y)
                .ToString();

            return result;
        }

        public static string Average()
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };

            var result = numbers.Average().ToString();

            return result;
        }

        public static dynamic Grouping()
        {
            var languages = new[]
                {
                    new
                    {
                        Name = "Haskell",
                        Type = "Functional",
                    },
                    new
                    {
                        Name = "Erlang",
                        Type = "Functional",
                    },
                    new
                    {
                        Name = "F#",
                        Type = "Functional",
                    },
                    new
                    {
                        Name = "C++",
                        Type = "Compiled",
                    },
                    new
                    {
                        Name = "ADA",
                        Type = "Compiled",
                    },
                    new
                    {
                        Name = "C#",
                        Type = "Compiled",
                    },
                    new
                    {
                        Name = "Python",
                        Type = "Compiled"
                    },
                    new
                    {
                        Name = "Javascript",
                        Type = "Interpreted"
                    },
                    new
                    {
                        Name = "Python",
                        Type = "Interpreted"
                    },
                    new
                    {
                        Name = "Basic",
                        Type = "Interpreted"
                    }
                };

            var gr = languages.GroupBy(x => x.Type).Select(x => new { Type = x.Key, Name = x.Select(z => z.Name) });

            return gr;
        }
    }
}
