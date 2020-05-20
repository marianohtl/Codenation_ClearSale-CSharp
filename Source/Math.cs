using System;
using System.Collections.Generic;

namespace Codenation.Challenge
{
    public class Math
    {
        public List<int> Fibonacci()
        {
            int n1 = 1, n2 = 0, sum = 0;

            List<int> sequence = new List<int>();

            sequence.Add(n2);
            while (sum <= 144)
            {
                sum = n1 + n2;  
                n1 = n2;        
                n2 = sum;
                sequence.Add(sum);
            }

            return sequence;
        }

        public bool IsFibonacci(int numberToTest)
        {
            bool isFibonacci = false;

            List<int> sequence = Fibonacci();

            foreach(int number in sequence)
            {
                if(number == numberToTest)
                {
                    isFibonacci = true;
                }
            }


            return isFibonacci;
        }
    }
}
