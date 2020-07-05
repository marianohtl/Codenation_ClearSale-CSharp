using System;

namespace Codenation.Challenge.Services
{
    public class RandomService: IRandomService
    {
        public int RandomInteger(int max)
        {
            var random = new System.Random().Next(0,max);
            return random;
        }
    }
}