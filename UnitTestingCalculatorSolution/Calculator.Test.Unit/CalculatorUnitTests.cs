using System;
using Calculator;
using NUnit.Framework;
using  CalculatorException;


namespace Calculator.Test.Unit
{
    [TestFixture]
    [Author("Troels Jensen - updated by group 16")]
    public class CalculatorUnitTests
    {
        private Calculator _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        [TestCase(0)]
        public void Accumulator_AccumulatorInitialTest_ResultIsCorrect(int result)
        {
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }

        [TestCase(3, 3, 6)]
        [TestCase(-3, -2, -5)]
        [TestCase(-3, 2, -1)]
        [TestCase(3, -2, 1)]
        public void Add_AddPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        [TestCase(3, -2, 5)]
        public void Subtract_SubtractPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(3, -2, -6)]
        [TestCase(0, -2, 0)]
        [TestCase(-2, 0, 0)]
        [TestCase(0, 0, 0)]
        public void Multiply_MultiplyNunmbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(result));
        }


        [TestCase(2, 3, 8)]
        [TestCase(2, -3, 0.125)]
        [TestCase(-2, -3, -0.125)]
        [TestCase(1, 10, 1)]
        [TestCase(1, -10, 1)]
        [TestCase(10, 0, 1)]
        [TestCase(4, 0.5, 2.0)]
		[TestCase(9, 0.5, 3.0)]
        [TestCase(-9, 0.5, -3.0)]
        [TestCase(0.5, -9, 512)]
        public void Power_RaiseNumbers_ResultIsCorrect(double x, double exp, double result)
        {
            Assert.That(_uut.Power(x, exp), Is.EqualTo(result));
        }


        [TestCase(1, 2, 0.5)]
        [TestCase(10, 2, 5)]
        [TestCase(1, 1, 1)]
        [TestCase(-2, 2, -1)]
        [TestCase(-4, -2, 2)]
        public void Divide_DivideNumbers_ResultIsCorrect(double a, double b, double result)
        {
            Assert.That(_uut.Divide(a, b), Is.EqualTo(result));
        }


        // Testing try-catch in dived -> dived-by-zero
        [TestCase(1,0,0)]
        public void Divide_DivideByZero_ResultIsCorrect(double a, double b, double result)
        {
            Assert.That(() => _uut.Divide(a, b), Throws.TypeOf<CalculatorException.NewDivideByZeroException>());
        }

        [TestCase(0)]
        public void Clear_ClearAccumulator_ResultIsCorrect(double result)
        {
            _uut.Clear();
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }

        [TestCase(1, 0, 1)]
        [TestCase(3, 1, 4)]
        [TestCase(4, 4, 8)]
        public void Overloaded_Add_ResultIsCorrect(double a, double prevResult, double result)
        {
            _uut.Add(prevResult);
            Assert.That(_uut.Add(a), Is.EqualTo(result));
        }


        [TestCase(-3, 1, 4)]
        [TestCase(4, 3, -1)]
        [TestCase(-1, -4, -3)]
        public void Overloaded_Subtract_ResultIsCorrect(double a, double prevResult, double result)
        {
            _uut.Add(prevResult);
            Assert.That(_uut.Subtract(a), Is.EqualTo(result));
        }

        
        [TestCase(2, 1, 0.5)]
        [TestCase(2, 28, 14)]
        [TestCase(14, 14, 1)]
        public void Overloaded_Divide_ResultIsCorrect(double a, double prevResult, double result)
        {
            _uut.Add(prevResult);
            Assert.That(_uut.Divide(a), Is.EqualTo(result));
        }


        [TestCase(1, 10, 10)]
        [TestCase(-3, 10, -30)]
        [TestCase(-0.5, -30, 15)]
        public void Overloaded_Multiply_ResultIsCorrect(double a, double prevResult, double result)
        {
            _uut.Add(prevResult);
            Assert.That(_uut.Multiply(a), Is.EqualTo(result));
        }


       // [TestCase(0, 11, 1)]
        //[TestCase(1, 3, 3)]
        //[TestCase(3, 2, 8)]
        [TestCase(2, 3, 8)]
        [TestCase(2, -3, 0.125)]
        [TestCase(-2, -3, -0.125)]
        [TestCase(1, 10, 1)]
        [TestCase(1, -10, 1)]
        [TestCase(10, 0, 1)]
        [TestCase(4, 0.5, 2.0)]
        [TestCase(0.5, -9, 512)]
        public void Overloaded_Power_ResultIsCorrect(double prevResult, double a, double result)
        {
            _uut.Add(prevResult);
            Assert.That(_uut.Power(a), Is.EqualTo(result));
        }        

        // Testing try-catch in dived -> dived-by-zero
        [TestCase(1.5,-9,0)]
        public void Power_Imaginary_ResultIsCorrect(double a, double b, double result)
        {
            _uut.Add(b);
            Assert.That(() => _uut.Power(a), Throws.TypeOf<CalculatorException.PowerImaginaryException>());
        }
    }
}
