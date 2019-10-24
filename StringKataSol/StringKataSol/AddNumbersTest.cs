using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StringKataInterview.test
{
    [TestFixture]
    public class AddNumbersTest
    {
        [Test]
        public void ReturnSumNumberEmptyReturns0Task1()
        {
            var rtn = StringKata.AddNumbers("");
            Assert.AreEqual(0, rtn);
        }

        [Test]
        public void ReturnSumOfNumbersCommaSeperatedTwoVariablesTask1()
        {
            var rtn = StringKata.AddNumbers("1,2");
            Assert.AreEqual(3, rtn);
        }

        [Test]
        public void ReturnSumOfNumbersCommaSeperatedManyVariablesTask2()
        {
            var rtn = StringKata.AddNumbers("1,2,3,4,5,6");
            Assert.AreEqual(21, rtn);
        }

        [Test]
        public void ReturnSumOfNumbersCommaAndLineBreakSeperatedManyVariablesTask3()
        {
            var rtn = StringKata.AddNumbers("1,2,3,4\n5,6");
            Assert.AreEqual(21, rtn);
        }

        [Test]
        public void ReturnSumNumberSeperatorIsPassedInTask4()
        {
            var rtn = StringKata.AddNumbers("//;\n1,2,3,4;5,6");
            Assert.AreEqual(21, rtn);
        }

        [Test]
        public void ReturnSumNumberSeperatorIsPassedInTask5()
        {
            var rtn = StringKata.AddNumbers("//[***]\n12***2***3");
            Assert.AreEqual(6, rtn);
        }

        //[Test]
        //public void ThrowexceptionOnNegative()
        //{
        //    try
        //    {
        //        var rtn = StringKata.AddNumbers("-1,1,-6");

        //    }
        //    catch (Exception ex)
        //    {
        //        Assert.Equals("negatives not allowed -1 -6", ex.Message);
        //    }
        //}
    }
}
