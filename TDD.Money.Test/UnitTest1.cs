using System;

namespace TDD.Money.Test
{
    public class UnitTest1
    {

        [Fact]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            Assert.Equal(new Dollar(10), five.times(2));
            Assert.Equal(new Dollar(15), five.times(3));
        }
        [Fact]
        public void testFrancMultiplication()
        {
            Franc five = new Franc(5);
            Assert.Equal(new Franc(10), five.times(2));
            Assert.Equal(new Franc(15), five.times(3));
        }
        //[Fact]
        //public void testEquality()
        //{
        //    Assert.True(new Dollar(5).Equals(new Dollar(5)));
        //    Assert.False(new Dollar(5).Equals(new Dollar(6)));
        //}
    }
}