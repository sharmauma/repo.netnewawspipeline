using System;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            System.Console.WriteLine("abc");
            Assert.Equal(1,1);
        }
    }
}
