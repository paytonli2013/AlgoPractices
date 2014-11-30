using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.IntegerMultiplication;
using System.Numerics;

namespace Algo.Tests.IntegerMultiplication
{
    [TestClass]
    public class KaratsubaTest
    {
        [TestMethod]
        public void Test2SmallNumber()
        {
            var algo = new KaratsubaMultiplication();

            BigInteger input1 = 12345678;
            BigInteger input2 = 223654899;
            BigInteger result = algo.Compute(Input.From<BigInteger, BigInteger>(input1, input2));

            Assert.AreEqual(result, input1 * input2);
        }
        
        [TestMethod]
        public void TestSmallAndBigNumbers()
        {
            var algo = new KaratsubaMultiplication();

            BigInteger input1 = 5678;
            BigInteger input2 = 2236548992111222222;
            BigInteger result = algo.Compute(Input.From<BigInteger, BigInteger>(input1, input2));

            Assert.AreEqual(result, input1 * input2);
        }

        [TestMethod]
        public void TestZeroAndNumber()
        {
            var algo = new KaratsubaMultiplication();

            BigInteger input1 = 0;
            BigInteger input2 = 2236548992111222222;
            BigInteger result = algo.Compute(Input.From<BigInteger, BigInteger>(input1, input2));

            Assert.AreEqual(result, BigInteger.Zero);
        }
    }
}
