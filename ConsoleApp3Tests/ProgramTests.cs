using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void ShellSortTest()
        {
            Assert.Fail();
        }
    }
}

namespace Rextester.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SortTest1()
        {
            int ZeroCheck = 0;
            var Sorting = new Program();

            Assert.AreEqual(Sorting.ReadElems(ZeroCheck.ToString()), 0);
        }

        [TestMethod()]
        public void SortTest2()
        {
            string StrCheck = "Test";
            double DoubleCheck = 333.6020814126;
            int NegativeIntCheck = -55;
            Int16 MaximumValueCheck = 32767;
            Int16 MinimumValueCheck = -32768;
            int ZeroCheck = 0;
            float FloatCheck = (float)333.602081;
            var Sorting = new Program();
            Assert.IsNotNull(Sorting.ReadNumOfElems(MaximumValueCheck.ToString()));
        }



        [TestMethod()]
        public void SortTest3()
        {
            string StrCheck = "Test";
            double DoubleCheck = 333.6020814126;
            int NegativeIntCheck = -55;
            Int16 MaximumValueCheck = 32767;
            Int16 MinimumValueCheck = -32768;
            int ZeroCheck = 0;
            float FloatCheck = (float)333.602081;
            var Sorting = new Program();
            Assert.IsNull(Sorting.ReadNumOfElems(MinimumValueCheck.ToString()));
        }


        [TestMethod()]
        public void SortTest5()
        {
            int[] arrRandom = { 1, 6, 4, 0, -2 };
            int[] arrCorrect = { -2, 0, 1, 4, 6 };
            float FloatCheck = (float)333.602081;
            var Sorting = new Program();
            Assert.AreEqual(Sorting.ShellSort(arrRandom), arrCorrect);
        }


        [TestMethod()]
        public void SortTest6()
        {
            int[] arrRandom = { 1, 6, 4, 0, -2 };
            int[] arrCorrect = { -2, 0, 1, 4, 6 };
            float FloatCheck = (float)333.602081;
            var Sorting = new Program();
            Assert.IsNull(Sorting.ShellSort(arrRandom));
        }

    }
}