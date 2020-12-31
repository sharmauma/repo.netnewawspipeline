using System;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //run unit test code
            Assert.Equal(1,1);
        }
        [Fact]
        public void Test2()
        {
            //run unit test code
            Assert.Equal(2,1);
        }        
    }
}
