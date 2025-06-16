using System;

namespace TDD.Money.Test
{
    public class UnitTest1
    {

        //[Fact]
        //public void TestMultiplication()
        //{
        //    Dollar five = new Dollar(5);
        //    Assert.Equal(new Dollar(10), five.times(2));
        //    Assert.Equal(new Dollar(15), five.times(3));
        //}
        //[Fact]
        //public void testFrancMultiplication()
        //{
        //    Franc five = new Franc(5);
        //    Assert.Equal(new Franc(10), five.times(2));
        //    Assert.Equal(new Franc(15), five.times(3));
        //}
        //[Fact]
        //public void testEquality()
        //{

        //    Assert.True(Money.dollar(5).Equals(Money.dollar(5)));
        //    Assert.False(Money.dollar(5).Equals(Money.dollar(6)));
        //    Assert.True(new Franc(5).Equals(new Franc(5)));
        //    Assert.False(new Franc(5).Equals(new Franc(6)));
        //    Assert.False(new Franc(5).Equals(Money.dollar(5)));
        //}

        //[Fact]
        //public void testMultiplication()
        //{
        //    Money five = Money.dollar(5);
        //    Assert.Equal(new Dollar(10), five.times(2));
        //    Assert.Equal(new Dollar(15), five.times(3));
        //}


        //[Fact]
        //public void testFrancMultiplication2()
        //{
        //    Money five = Money.franc(5);
        //    Assert.Equal(new Franc(10), five.times(2));
        //    Assert.Equal(new Franc(15), five.times(3));
        //}


        [Fact]
        public void testCurrency() {
            Assert.Equal("USD", Money.dollar(1).Getcurrency());
            Assert.Equal("CHF",Money.franc(1).Getcurrency());
        }

        [Fact]
        public void testDifferentClassEquality()
        {
            Assert.True(new Money(10, "CHF").Equals(new Franc(10,
            "CHF")));
        }

    }
}