using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LargestNeighbour;

namespace LargestNeighbourTest
{
    [TestClass]
    public class SumOfLargestNeighbourTest
    {
        [TestMethod]
        public void InitializeArray_SumLargestNeighbour_VerifySumofLargestNeighbour()
        {
            int[] input = new int[] { 1, 6, 1, 2, 6, 1, 6, 6 };
            int sum = Program.Challenge(input);
            Assert.AreEqual(12, sum, "Sum is not equal to the expected one");
        }
    }
}
