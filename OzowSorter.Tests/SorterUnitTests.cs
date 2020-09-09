using System;
using Xunit;

namespace OzowSorter.Tests
{
    public class SorterUnitTests
    {
        [Fact]
        public void GivenAnArbitraryString_ShouldRemoveEmptySpaces()
        {
            var input = "Contrary to popular belief the pink unicorn flies east";

            var expected = "Contrarytopopularbeliefthepinkunicornflieseast";

            var actual = input.RemoveWhiteSpacesAndPunctuation();


            Assert.Equal(expected, actual);
        }

    }
}
