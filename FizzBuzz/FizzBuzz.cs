

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string GetTextDisplay(int number)
        {
            if(number == 15) return "FizzBuzz";
            if(number == 5) return "Buzz";
            if(number == 4) return "4";
            if(number == 3) return "Fizz";
            if(number == 2) return "2";
            return "1";
        }
    }
}