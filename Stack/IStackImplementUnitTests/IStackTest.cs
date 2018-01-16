namespace IStackImplementUnitTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Datastruct;

    [TestClass]
    public class IStackTest
    {
        private const int stackDfSize = 10;

        [TestMethod]
        public void DefaultInitTest()
        {
            Stack<int> temp = new Stack<int>();
            NullReferenceException nlEx = null;
            try
            {
                var tmp = temp.Size;
            }
            catch (NullReferenceException ex)
            {
                nlEx = ex;
            }

            Assert.AreNotEqual(nlEx, null);
        }

        [TestMethod]
        public void InitTest()
        {
            Stack<int> temp = new Stack<int>(stackDfSize);
            Assert.AreEqual(temp.Count, 0);
            Assert.AreEqual(temp.Size, stackDfSize);
        }

        [TestMethod]
        public void TopTestFirst()
        {
            Stack<int> temp = new Stack<int>(stackDfSize);

            int pushedValue = 1;
            temp.Push(pushedValue);

            Assert.AreEqual(temp.Size, stackDfSize);
            Assert.AreEqual(temp.Top(), pushedValue);
            Assert.AreEqual(temp.Count, 1);
        }

        [TestMethod]
        public void TopTestMiddle()
        {
            Stack<int> temp = new Stack<int>(stackDfSize);

            int firstPushedValue = -19;
            int pushedValuesCount = stackDfSize / 2;
            int difference = 0;
            for (int i = 0; i < pushedValuesCount; i++)
            {
                difference += i + 1;
                temp.Push(firstPushedValue + difference);
            }

            Assert.AreEqual(temp.Count, pushedValuesCount);
            Assert.AreEqual(temp.Size, stackDfSize);
            Assert.AreEqual(temp.Top(), firstPushedValue + difference);
        }

        [TestMethod]
        public void TopTestLast()
        {
            Stack<int> temp = new Stack<int>(stackDfSize);

            int firstPushedValue = 1291;
            int difference = 0;
            for (int i = 0; i < temp.Size; i++)
            {
                difference += i + 1;
                temp.Push(firstPushedValue + difference);
            }

            Assert.AreEqual(temp.Count, stackDfSize);
            Assert.AreEqual(temp.Size, stackDfSize);
            Assert.AreEqual(temp.Top(), firstPushedValue + difference);
        }

        [TestMethod]
        public void PushTestFirst()
        {
            Stack<int> temp = new Stack<int>(stackDfSize);

            int pushedValue = -991;
            temp.Push(pushedValue);

            Assert.AreEqual(temp.Count, 1);
            Assert.AreEqual(temp.Size, stackDfSize);
            Assert.AreEqual(temp.Top(), pushedValue);
        }

        [TestMethod]
        public void PushTestLast()
        {
            Stack<int> temp = new Stack<int>(stackDfSize);

            int pushedValue = 92;
            for (int i = 0; i < temp.Size; i++)
            {
                temp.Push(pushedValue);
            }

            Assert.AreEqual(temp.Count, stackDfSize);
            Assert.AreEqual(temp.Size, stackDfSize);
            Assert.AreEqual(temp.Top(), pushedValue);
        }

        [TestMethod]
        public void PopTestFirst()
        {
            Stack<int> temp = new Stack<int>(stackDfSize);

            int pushedValue = 92;
            temp.Push(pushedValue);

            Assert.AreEqual(temp.Count, 1);
            Assert.AreEqual(temp.Size, stackDfSize);

            temp.Pop();

            Assert.AreEqual(temp.Count, 0);
            Assert.AreEqual(temp.Size, stackDfSize);
        }

        [TestMethod]
        public void PopTestMiddle()
        {
            Stack<int> temp = new Stack<int>(stackDfSize);

            int pushedValue = 92;
            int pushedValuesCount = stackDfSize / 2;
            for (int i = 0; i < pushedValuesCount; i++)
            {
                temp.Push(pushedValue);
            }

            temp.Pop();

            Assert.AreEqual(temp.Count, pushedValuesCount - 1);
            Assert.AreEqual(temp.Size, stackDfSize);
        }

        [TestMethod]
        public void PopTestLast()
        {
            Stack<int> temp = new Stack<int>(stackDfSize);

            int pushedValue = 483;
            for (int i = 0; i < temp.Size; i++)
            {
                temp.Push(pushedValue);
            }

            temp.Pop();

            Assert.AreEqual(temp.Count, stackDfSize - 1);
            Assert.AreEqual(temp.Size, stackDfSize);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void PopExceptionTestFirst()
        {
            Stack<int> temp = new Stack<int>(stackDfSize);

            int pushedValue = 44;
            temp.Push(pushedValue);

            temp.Pop();

            temp.Pop();

            Assert.AreEqual(temp.Count, 0);
            Assert.AreEqual(temp.Size, stackDfSize);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void PopExceptionTestLast()
        {
            Stack<int> temp = new Stack<int>(stackDfSize);

            int pushedValue = 484;
            for (int i = 0; i < temp.Size; i++)
            {
                temp.Push(pushedValue);
            }

            for (int i = 0; i < temp.Size; i++)
            {
                temp.Pop();
            }

            temp.Pop();

            Assert.AreEqual(temp.Count, 0);
            Assert.AreEqual(temp.Size, stackDfSize);
        }

        [TestMethod]
        public void TopExceptionTest()
        {
            Stack<int> temp = new Stack<int>(stackDfSize);

            try
            {
                temp.Top();
            }
            catch (IndexOutOfRangeException ex)
            {
                Assert.AreEqual("Stack doesn't have nodes", ex.Message);
            }

            Assert.AreEqual(temp.Count, 0);
            Assert.AreEqual(temp.Size, stackDfSize);
        }

        [TestMethod]
        [ExpectedException(typeof(StackOverflowException))]
        public void PushException()
        {
            Stack<int> temp = new Stack<int>(stackDfSize);

            int pushedValue = -921;
            for (int i = 0; i < temp.Size; i++)
            {
                temp.Push(pushedValue);
            }

            temp.Push(pushedValue);

            Assert.AreEqual(temp.Count, stackDfSize);
            Assert.AreEqual(temp.Size, stackDfSize);
        }
    }
}