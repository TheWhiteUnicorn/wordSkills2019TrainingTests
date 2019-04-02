using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorAndTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculatorUnitTests
    {
        [TestMethod]
        public void SumMethod()
        {
            Assert.AreEqual(MathModule.Sum(2d, 2d), 4d);

            Assert.AreEqual(MathModule.Sum(0d, 0d), 0d);
            Assert.AreEqual(MathModule.Sum(0d, -0d), 0d);

            Assert.AreEqual(MathModule.Sum(5d, -6d), -1d);
            Assert.AreEqual(MathModule.Sum(-5d, -6d), -11d);
            Assert.AreEqual(MathModule.Sum(-5d, 6d), 1d);

            Assert.AreEqual(MathModule.Sum(9.9d, 9.9d), 19.8d);
            Assert.AreEqual(MathModule.Sum(0.5d, 0.5d), 1d);

            Assert.AreEqual(MathModule.Sum(MathModule.MAX_OPERAND_VAL, 0), MathModule.MAX_OPERAND_VAL);
            Assert.AreEqual(MathModule.Sum(9.9999999e+7, 9.9999999e+7), 199999998);
            Assert.AreEqual(MathModule.Sum(-9.999999e+6, -9.999999e+6), -19999998);
        }

        [TestMethod]
        public void SubstractMethod()
        {
            Assert.AreEqual(MathModule.Substract(4d, 2d), 2d);

            Assert.AreEqual(MathModule.Substract(0d, 0d), 0d);
            Assert.AreEqual(MathModule.Substract(0d, -0d), 0d);

            Assert.AreEqual(MathModule.Substract(5d, -6d), 11d);
            Assert.AreEqual(MathModule.Substract(-5d, -6d), 1d);
            Assert.AreEqual(MathModule.Substract(-5d, 6d), -11d);

            Assert.AreEqual(MathModule.Substract(0.9d, 0.5d), 0.4d);
            Assert.AreEqual(MathModule.Substract(19.8d, 9.9d), 9.9d);            

            Assert.AreEqual(MathModule.Substract(MathModule.MAX_OPERAND_VAL, 0), MathModule.MAX_OPERAND_VAL);
            Assert.AreEqual(MathModule.Substract(MathModule.MAX_OPERAND_VAL, MathModule.MAX_OPERAND_VAL), 0);
            Assert.AreEqual(MathModule.Substract(9.9999999e+7, -9.999999e+6), 109999998);
            Assert.AreEqual(MathModule.Substract(-9.999999e+6, 9.9999999e+7), -109999998);
        }

        [TestMethod]
        public void MultiplyMethod()
        {
            Assert.AreEqual(MathModule.Multiply(2d, 3d), 6d);

            Assert.AreEqual(MathModule.Multiply(0d, 0d), 0d);
            Assert.AreEqual(MathModule.Multiply(0d, -0d), 0d);

            Assert.AreEqual(MathModule.Multiply(5d, 0d), 0d);
            Assert.AreEqual(MathModule.Multiply(0d, 5d), 0d);

            Assert.AreEqual(MathModule.Multiply(1d, 1d), 1d);
            Assert.AreEqual(MathModule.Multiply(-1d, 1d), -1d);
            Assert.AreEqual(MathModule.Multiply(1d, -1d), -1d);
            Assert.AreEqual(MathModule.Multiply(-1d, -1d), 1d);

            Assert.AreEqual(MathModule.Multiply(9.9999999e+7, 9.9999999e+7), 9999999800000001);
            Assert.AreEqual(MathModule.Multiply(-9.999999e+6, -9.999999e+6), 99999980000001);
        }

        [TestMethod]
        public void DivideMethod()
        {
            Assert.AreEqual(MathModule.Divide(3d, 2d), 1.5d);
            Assert.AreEqual(MathModule.Divide(2d, 3d), 0.66666666666667d);
            Assert.AreEqual(MathModule.Divide(1d, 3d), 0.33333333333333d);

            Assert.AreEqual(MathModule.Divide(1d, 1d), 1d);
            Assert.AreEqual(MathModule.Divide(-1d, 1d), -1d);
            Assert.AreEqual(MathModule.Divide(1d, -1d), -1d);
            Assert.AreEqual(MathModule.Divide(-1d, -1d), 1d);

            Assert.AreEqual(MathModule.Divide(0d, 9d), 0d);
            Assert.AreEqual(MathModule.Divide(-0d, 9d), 0d);
            Assert.AreEqual(MathModule.Divide(0d, -9d), 0d);
            Assert.AreEqual(MathModule.Divide(-0d, -9d), 0d);

            Assert.AreEqual(MathModule.Divide(9.9999999e+7, 9.9999999e+7), 1);
            Assert.AreEqual(MathModule.Divide(-9.999999e+6, -9.999999e+6), 1);
            Assert.AreEqual(MathModule.Divide(1e-6, 9.9999999e+7), 1E-14);

            Assert.AreEqual(MathModule.Divide(1d, 0d), double.PositiveInfinity);
            Assert.AreEqual(MathModule.Divide(-1d, 0d), double.NegativeInfinity);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Argument out of bounds")]
        public void CheckOperandsMethodExceptsBiggerFirst()
        {
            MathModule.CheckOperands(1E+8d, 1d);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Argument out of bounds")]
        public void CheckOperandsMethodExceptsBiggerSecond()
        {
            MathModule.CheckOperands(1d, 1E+8d);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Argument out of bounds")]
        public void CheckOperandsMethodExceptsLessFirst()
        {
            MathModule.CheckOperands(-1E+7d, 1d);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Argument out of bounds")]
        public void CheckOperandsMethodExceptsLessSecond()
        {
            MathModule.CheckOperands(1d, -1E+7d);
        }
    }
}
