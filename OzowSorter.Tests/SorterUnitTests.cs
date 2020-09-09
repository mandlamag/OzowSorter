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

        [Fact]
        public void GivenAnArbitraryString_ShouldIgnoreAllPanctuation()
        {
            var input = "Contrary to popular belief, the pink unicorn flies east.";

            var expected = "Contrarytopopularbeliefthepinkunicornflieseast";

            var actual = input.RemoveWhiteSpacesAndPunctuation();


            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenAnArbitraryString_ShouldSortInAlphabeticalOrder()
        {
            var input = "contrarytopopularbeliefthepinkunicornflieseast";

            var expected = "aaabcceeeeeffhiiiiklllnnnnooooppprrrrssttttuuy";

            var actual = input.ToSorted();


            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenAnArbitraryString_ShouldRemoveSpacesAndSortInAlphabeticalOrder()
        {
            var input = "Contrary? to #popular! belief, the pink unicorn flies east.";

            var expected = "aaabcceeeeeffhiiiiklllnnnnooooppprrrrssttttuuy";

            var actual = input.TrimAndSort();


            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveWhiteSpacesAndPunctuation_GivenNullInput_ShouldThrowAnArgumentNullException()
        {
            string input = null;


            Action act = () => input.RemoveWhiteSpacesAndPunctuation();


            Assert.Throws<ArgumentNullException>(act);
        }

        [Fact]
        public void ToSorted_GivenNullInput_ShouldThrowAnArgumentNullException()
        {
            string input = null;


            Action act = () => input.ToSorted();


            Assert.Throws<ArgumentNullException>(act);
        }

        [Fact]
        public void TrimAndSort_GivenNullInput_ShouldThrowAnArgumentNullException()
        {
            string input = null;


            Action act = () => input.TrimAndSort();


            Assert.Throws<ArgumentNullException>(act);
        }

        [Fact]
        public void TrimAndSort_GivenEmptyInput_ShouldThrowAnArgumentNullException()
        {
            string input = "";


            Action act = () => input.TrimAndSort();


            Assert.Throws<ArgumentException>(act);
        }



    }
}
