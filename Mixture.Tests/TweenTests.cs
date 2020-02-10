using System;
using FluentAssertions;
using Xunit;

namespace Mixture.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var tween = Tween.For<int>();

            tween.Should().NotBeNull();
        }
    }
}
