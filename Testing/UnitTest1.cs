using Xunit;
using CurrencyConverter;

namespace CurrencyCoverter.Test
{
    public class UnitTest1
    {
        Menu menu = new Menu();
        [Fact]
        public void Converter_CorrectConversionToBeProvided()
        {
            double expected = 56;

            double actual = menu.Converter(2,50);

            Assert.Equal(expected, actual, 2);
        }
    }
}
