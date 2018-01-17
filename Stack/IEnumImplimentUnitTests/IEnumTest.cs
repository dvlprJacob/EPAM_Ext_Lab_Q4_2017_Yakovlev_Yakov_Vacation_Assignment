namespace IEnumImplimentUnitTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Datastruct;

    [TestClass]
    public class IEnumTest
    {
        private const int DfStSize = 10;

        [TestMethod]
        public void ForeachTestInEmptyStack()
        {
            Exception checkEx = null;
            Stack<int> temp = new Stack<int>();
            int checkValue = 0;
            int checkCorrectValue = 0;

            try
            {
                foreach (var node in temp)
                {
                    checkValue++;
                }
            }
            catch (NullReferenceException nlrEx)
            {
                checkEx = nlrEx;
            }

            Assert.AreEqual(checkEx, null);
            Assert.AreEqual(checkValue, checkCorrectValue);
        }

        [TestMethod]
        public void ForeachTestInFullPushedStack()
        {
            Exception checkEx = null;
            int pushedValue = 109;
            Stack<int> temp = new Stack<int>(DfStSize);
            int checkValue = 0;

            try
            {
                for (int i = 0; i < temp.Size; i++)
                {
                    temp.Push(pushedValue);
                }

                foreach (var node in temp)
                {
                    checkValue++;
                }
            }
            catch (Exception ex)
            {
                checkEx = ex;
            }

            Assert.AreEqual(checkValue, temp.Size);
            Assert.AreEqual(checkEx, null);
        }

        [TestMethod]
        public void ForeachTestInMiddlePushedStack()
        {
            Exception checkEx = null;
            int pushedValue = 1043;
            Stack<int> temp = new Stack<int>(DfStSize);
            int checkValue = 0;
            int pushedValuesCount = temp.Size / 2;

            try
            {
                for (int i = 0; i < pushedValuesCount; i++)
                {
                    temp.Push(pushedValue);
                }

                foreach (var node in temp)
                {
                    checkValue++;
                }
            }
            catch (Exception ex)
            {
                checkEx = ex;
            }

            Assert.AreEqual(checkValue, pushedValuesCount);
            Assert.AreEqual(checkEx, null);
        }

        [TestMethod]
        public void ForeachTestAfterPopFirst()
        {
            Exception checkEx = null;
            int pushedValue = 1129;
            Stack<int> temp = new Stack<int>(DfStSize);
            int checkValue = 0;
            int checkCorrectValue = 0;

            try
            {
                temp.Push(pushedValue);
                temp.Pop();

                foreach (var node in temp)
                {
                    checkValue++;
                }
            }
            catch (Exception ex)
            {
                checkEx = ex;
            }

            Assert.AreEqual(checkValue, checkCorrectValue);
            Assert.AreEqual(checkEx, null);
        }

        [TestMethod]
        public void ForeachTestAfterPopMiddle()
        {
            Exception checkEx = null;
            int pushedValue = 1129;
            Stack<int> temp = new Stack<int>(DfStSize);
            int checkValue = 0;
            int pushedValuesCount = temp.Size / 2;
            int checkCorrectValue = pushedValuesCount - 1;

            try
            {
                for (int i = 0; i < pushedValuesCount; i++)
                {
                    temp.Push(pushedValue);
                }

                temp.Pop();

                foreach (var node in temp)
                {
                    checkValue++;
                }
            }
            catch (Exception ex)
            {
                checkEx = ex;
            }

            Assert.AreEqual(checkValue, checkCorrectValue);
            Assert.AreEqual(checkEx, null);
        }

        [TestMethod]
        public void ForeachTestAfterPopLast()
        {
            Exception checkEx = null;
            int pushedValue = 1129;
            Stack<int> temp = new Stack<int>(DfStSize);
            int checkValue = 0;
            int checkCorrectValue = temp.Size - 1;

            try
            {
                for (int i = 0; i < temp.Size; i++)
                {
                    temp.Push(pushedValue);
                }

                temp.Pop();

                foreach (var node in temp)
                {
                    checkValue++;
                }
            }
            catch (Exception ex)
            {
                checkEx = ex;
            }

            Assert.AreEqual(checkValue, checkCorrectValue);
            Assert.AreEqual(checkEx, null);
        }

        [TestMethod]
        public void ForeachTestAfterPopAll()
        {
            Exception checkEx = null;
            int pushedValue = 1129;
            Stack<int> temp = new Stack<int>(DfStSize);
            int checkValue = 0;
            int checkCountValue = 0;

            try
            {
                for (int i = 0; i < temp.Size; i++)
                {
                    temp.Push(pushedValue);
                }

                for (int i = 0; i < 10; i++)
                {
                    temp.Pop();
                }

                foreach (var node in temp)
                {
                    checkValue++;
                }
            }
            catch (Exception ex)
            {
                checkEx = ex;
            }

            Assert.AreEqual(checkValue, checkCountValue);
            Assert.AreEqual(checkEx, null);
        }
    }
}