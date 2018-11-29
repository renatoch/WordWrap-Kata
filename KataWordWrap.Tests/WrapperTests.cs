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
        public void GivenOneWordLengthMoreThanColumnsReturnWrappedWord() {
            const string input = "Word";
            var result = Wrapper.Wrap(input, input.Length - 1);
            Assert.AreEqual("Wor\nd", result);
        }

        [TestMethod]
        public void GivenTwoWordsLengthLessThanColumnsReturnThem() {
            const string input = "Two Words";
            var result = Wrapper.Wrap(input, input.Length + 1);
            Assert.AreEqual(input, result);
        }

        [TestMethod]
        public void GivenTwoWordsLengthMoreThanColumnsReturnThemWrappedInSpace() {
            const string input = "Two Words";
            var result = Wrapper.Wrap(input, input.Length - 1);
            Assert.AreEqual("Two\nWords", result);
        }

        [TestMethod]
        public void WrapMoreThan2WordsOnLastSpace() {
            const string input = "More than 2 words";
            var result = Wrapper.Wrap(input, input.Length - 1);
            Assert.AreEqual("More than 2\nwords", result);
        }

        [TestMethod]
        public void WrapOneLineWithMultipleWordsOnEachLine() {
            const string input = "Hoje é domingo, pede cachimbo.";
            var result = Wrapper.Wrap(input, "Hoje é domingo, ".Length);
            Assert.AreEqual("Hoje é domingo,\npede cachimbo.", result);
        }
        
        [TestMethod]
        public void WrapMultipleLinesWithMultipleWordsOnEachLine() {
            const string input = "Hoje é domingo. Hoje é domingo. Hoje é domingo.";
            var result = Wrapper.Wrap(input, "Hoje é domingo. ".Length);
            Assert.AreEqual("Hoje é domingo.\nHoje é domingo.\nHoje é domingo.", result);
        }

        //TODO WrapOneLineWithMultipleWordsOnEachLine quebrando logo antes no espaço
        //TODO Outros separadores além de " " (, . ; ...)
    }
}
