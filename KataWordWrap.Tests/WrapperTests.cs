using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataWordWrap.Tests
{
    [TestClass]
    public class WrapperTests
    {
        [TestMethod]
        public void GivenEmptyReturnEmpty() {
            var result = Wrapper.Wrap("", 1);
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void GivenOneCharReturnIt() {
            const string charInput = "A";
            var result = Wrapper.Wrap(charInput, 1);
            Assert.AreEqual(charInput, result);
        }

        [TestMethod]
        public void GivenOneWordSameLengthThanColumnsReturnIt() {
            const string input = "Word";
            var result = Wrapper.Wrap(input, input.Length);
            Assert.AreEqual(input, result);
        }

        [TestMethod]
        public void GivenOneWordLengthLessThanColumnsReturnWrappedWord() {
            const string input = "Word";
            var result = Wrapper.Wrap(input, input.Length - 1);
            Assert.AreEqual("Wor\nd", result);
        }
    }
}
