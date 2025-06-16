using System;

namespace TDD.Money.Test
{
    public class UnitTest1
    {



        [Fact]
        public void testEquality()
        {
            Assert.True(Money.dollar(5).Equals(Money.dollar(5)));
            Assert.False(Money.dollar(5).Equals(Money.dollar(6)));
            Assert.False(Money.franc(5).Equals(Money.dollar(5)));
        }

    }
}