using System;
using Xunit;

namespace PrimeLibrary.Tests
{
    public class PrimeService_Tests
    {
        private readonly PrimeService _primeService;

        public PrimeService_Tests()
        {
            _primeService = new PrimeService();
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);
            Assert.False(result, $"{value} should not be prime");
        }

        [Fact]
        public void IsPrime_InputIs3_ReturnTrue()
        {
            var result = _primeService.IsPrime(3);
            Assert.True(result);
        }

        [Fact]
        public void IsPrime_InputIs4_ReturnFalse()
        {
            var result = _primeService.IsPrime(4);
            Assert.False(result);
        }
    }
}
