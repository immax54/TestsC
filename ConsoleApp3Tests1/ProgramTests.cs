using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Assert.AreNotEqual(Sorting.ReadElems(ZeroCheck.ToString()), ZeroCheck);
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
            Assert.IsNotNull(Sorting.ReadNumOfElems(MinimumValueCheck.ToString()));
        }


        [TestMethod()]
        public void SortTest4()
        {
            var Sorting = new Program();
            int[] arrRandom = { 1, 6, 4, 0, -2 };
            int[] arrCorrect = { -2, 0, 1, 4, 6 };
            int[] arrCheck = Sorting.Sorting(arrRandom);
            float FloatCheck = (float)333.602081;
            Assert.AreEqual(arrCheck[0], arrCorrect[0]);
        }


        [TestMethod()]
        public void SortTest5()
        {
            int[] arrRandom = { 1, 6, 4, 0, -2 };
            int[] arrCorrect = { -2, 0, 1, 4, 6 };
            float FloatCheck = (float)333.602081;
            var Sorting = new Program();
            Assert.IsNotNull(Sorting.Sorting(arrRandom));
        }


        [TestMethod()]
        public void SortTest6()
        {
            var Sorting = new Program();
            int[] arrRandom = { 1, 6, 4, 0, -2 };
            int[] arrCorrect = { -2, 0, 1, 4, 6 };
            int[] arrCheck = Sorting.Sorting(arrRandom);
            float FloatCheck = (float)333.602081;
            Assert.AreEqual(arrCheck[arrCheck.Length-1], arrCorrect[arrCorrect.Length-1]);
        }

        [TestMethod()]
        public void SortTest7()
        {
            var Sorting = new Program();
            int[] arrRandom = { 1, 6, 4, 0, -2 };
            int[] arrCorrect = { -2, 0, 1, 4, 6 };
            int[] arrCheck = Sorting.Sorting(arrRandom);
            float FloatCheck = (float)333.602081;
            Assert.AreEqual(arrCheck[arrCheck.Length/2], arrCorrect[arrCorrect.Length/2]);
        }


        [TestMethod()]
        public void SortTest8()
        {
            var Sorting = new Program();
            int[] arrRandom = { 1, 6, 4, 0, -2 };
            int[] arrCheck = Sorting.Sorting(arrRandom);
            float FloatCheck = (float)333.602081;
            arrCheck[0].GetType().IsInstanceOfType(arrRandom);
        }


        [TestMethod()]
        public void SortTest9()
        {
            var Sorting = new Program();
            int[] arrRandom = { 1, 6, 4, 0, -2 };
            int[] arrCheck = Sorting.Sorting(arrRandom);
            float FloatCheck = (float)333.602081;
            arrRandom[0].GetType().IsInstanceOfType(arrCheck);
        }

        [TestMethod()]
        public void SortTest10()
        {
            var Sorting = new Program();
            int[] arrRandom = { 1, 6, 4, 0, -2 };
            int[] arrCheck = Sorting.Sorting(arrRandom);
            float FloatCheck = (float)333.602081;
            Assert.AreEqual(arrRandom.Length, arrCheck.Length);
        }



        [TestMethod()]
        public void SortTest11()
        {
            var Sorting = new Program();
            int[] arrRandom = { 1, 6, 4, 0, -2 };
            int[] arrCheck = Sorting.Sorting(arrRandom);
            float FloatCheck = (float)333.602081;
            Assert.AreSame(arrRandom, arrCheck);
        }

        [TestMethod()]
        public void SortTest12()
        {
            string String = "0";
            var Sorting = new Program();
            Assert.AreNotEqual(Sorting.ReadElems(String), String);

        }
        [TestMethod()]
        public void SortTest13()
        {
            int NegativeIntCheck = -55;
            var Sorting = new Program();
            Assert.IsNotNull(Sorting.ReadElems(NegativeIntCheck.ToString()));

        }
        [TestMethod()]
        public void SortTest14()
        {
            Int16 MinimumValueCheck = -32768;
            var Sorting = new Program();
            Assert.IsNotNull(Sorting.ReadElems(MinimumValueCheck.ToString()));

        }

        [TestMethod()]
        public void SortTest15()
        {
            var Sorting = new Program();
            int[] arrRandom = { 1, 6, 4, 0, -2 };
            int[] arrCorrect = { -2, 0, 1, 4, 6 };
            int[] arrCheck = Sorting.Sorting(arrRandom);
            float FloatCheck = (float)333.602081;
            Assert.AreEqual(arrCheck[arrCheck.Length/2-1], arrCorrect[arrCorrect.Length/2-1]);

        }
    }
}