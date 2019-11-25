using System;
using Xunit;

namespace PrimeLibrary.Tests
{
    public class ManTimeService_Tests
    {
        private readonly ManTimeService _manTimeService;

        public ManTimeService_Tests()
        {
            _manTimeService = new ManTimeService();
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(1, 2, 0.5)]
        public void ManHours(int hours, int men, double expected)
        {
            var result = _manTimeService.CalculateManHours(hours, men);
            Assert.Equal(expected, result);
        }

    }
}
