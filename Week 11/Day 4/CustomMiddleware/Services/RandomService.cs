using System;

namespace CustomMiddleware.Services
{
    public class RandomService : IRandomService
    {
        private int _random;
        public RandomService()
        {
            Random random = new Random();
            _random = random.Next(1000);
        }
        public int GetNumber()
        {
            return _random;
        }
    }
}
