using System;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            System.Console.WriteLine("xunit test");
            Assert.Equal(1,2);
        }
    }
}
