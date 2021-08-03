using System.Collections.Generic;

namespace FizzBuzzKata.Tests
{
    public class FizzBuzz
    {
        public List<string> PrintList()
        {
            var strings = new List<string>();
            for (int i = 1; i <= 100; i++)
            { 
                strings.Add(GenerateFizzBuzz(i)); 
            }

            return strings;
        }


        public string GenerateFizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                return "PrintList";

            if (number % 3 == 0)
                return "Fizz";

            if (number % 5 == 0)
                return "Buzz";

            return number.ToString();
        }
    }
}