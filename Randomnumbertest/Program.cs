using System;

namespace Randomnumbertest
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var resultingArray = new int[1000];
            for(var i = 0; i < 1000; i++)
            {
                resultingArray[i] = i + 1;
            }

            for(var i = 0; i < 1000; i++)
            {
                var firstAddress = random.Next(0, 999);
                var secondAddress = random.Next(0, 999);
                int temp = resultingArray[firstAddress];
                resultingArray[firstAddress] = resultingArray[secondAddress];
                resultingArray[secondAddress] = temp;
            }
        }

    }
}
