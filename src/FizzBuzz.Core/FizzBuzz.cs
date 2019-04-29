using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.Core
{
    public class FizzBuzz
    {
        public static IEnumerable<string> GetFizzBuzz(int quantity) =>
            Enumerable.Range(1, quantity)
            .Select(n => (n % 3, n % 5) switch
            {
                (0, 0) => "FizzBuzz",
                (0, _) => "Fizz",
                (_, 0) => "Buzz",
                (_, _) => n.ToString(),
            });
    }
}
