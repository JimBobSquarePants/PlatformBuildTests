using System;
using Xunit;

namespace PlatformBuildTests
{
    public class UnitTest1
    {
        [Fact]
        public void Is32BitProcess()
        {
            Assert.True(!Environment.Is64BitProcess);
        }

        [Fact]
        public void Is64BitProcess()
        {
            Assert.True(Environment.Is64BitProcess);
        }
    }
}
