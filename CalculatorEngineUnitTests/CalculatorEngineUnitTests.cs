namespace CalculatorEngineUnitTests;
using CalculatorEngine;

public class Tests
{
    private CalculatorEngine _calculatorEngine;
    private double Tolerance = 0.000000001;
    [SetUp]
    public void Setup()
    {
        _calculatorEngine = new CalculatorEngine();
    }

    [Test]
    public void Addition_AddTwoNumbers_ReturnsCorrectNumber()
    {
        //preq-UNIT-TEST-2
        //Arrange
        double ExpectedResult = 2.35;
        double x = 5.5;
        double y = -3.15;
        //Act
        double result = _calculatorEngine.Addition(x, y);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }

    [Test]
    public void Subtraction_SubtractTwoNumbers_ReturnsCorrectNumber()
    {
        //preq-UNIT-TEST-3
        //Arrange
        double ExpectedResult = 23.93;
        double x = 27.93;
        double y = 4;
        //Act
        double result = _calculatorEngine.Subtraction(x, y);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void Multiplication_MultiplyTwoNumbers_ReturnsCorrectNumber()
    {
        //preq-UNIT-TEST-4
        //Arrange
        double ExpectedResult = 35.5;
        double x = 5;
        double y = 7.1;
        //Act
        double result = _calculatorEngine.Multiplication(x, y);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void Division_DivideTwoNumbers_ReturnsCorrectNumbers()
    {
        //preq-UNIT-TEST-5
        //Arrange
        double ExpectedResult = 3.0 / 9.0; //TODO I am pretty such that this is wrong lol!!!!!
        double x = 3.0;
        double y = 9.0;
        //Act
        double result = _calculatorEngine.Division(x, y);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void Division_DivideByZero_ReturnsInfinity()
    {
        //preq-UNIT-TEST-6
        //Arrange
        double ExpectedResult = double.PositiveInfinity;
        double x = 5;
        double y = 0;
        //Act
        double result = _calculatorEngine.Division(x, y);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void Equals_ChecksForSameNumber_ReturnsTrue()
    {
        //preq-UNIT-TEST-7
        //Arrange
        double ExpectedResult = 1;
        double x = 0.333333;
        double y = 0.333333;
        //Act
        double result = _calculatorEngine.Equals(x, y);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void Equals_ChecksForSameNumber_ReturnsFalse()
    {
        //preq-UNIT-TEST-7
        //Arrange
        double ExpectedResult = 0;
        double x = 0.33333333;
        double y = 0.33333334;
        //Act
        double result = _calculatorEngine.Equals(x, y);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void Equals_ChecksForSameNumberPastTolerance_ReturnsTrue()
    {
        //preq-UNIT-TEST-7
        //Arrange
        double ExpectedResult = 1;
        double x = 0.333333331;
        double y = 0.333333332;
        //Act
        double result = _calculatorEngine.Equals(x, y);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void RaiseToPower_TakesThePower_ReturnsCorrectNumber()
    {
        //preq-UNIT-TEST-8
        //Arrange
        double ExpectedResult = 8;
        double x = 2;
        double y = 3;
        //Act
        double result = _calculatorEngine.RaiseToPower(x, y);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void Log_LogWithCustomBase_ReturnsCorrectNumber()
    {
        //preq-UNIT-TEST-9
        //Arrange
        double ExpectedResult = 3;
        double x = 8;
        double y = 2;
        //Act
        double result = _calculatorEngine.LogOfNumber(x, y);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void Log_XValueLessThanOrEqualToZero_ReturnsInfinity()
    {
        //preq-UNIT-TEST-10
        //Arrange
        double ExpectedResult = double.NegativeInfinity;
        double x = 0;
        double y = 2;
        //Act
        double result = _calculatorEngine.LogOfNumber(x, y);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void Log_YValueIsEqualToZero_ReturnsNaN()
    {
        //preq-UNIT-TEST-11
        //Arrange
        double ExpectedResult = double.NaN;
        double x = 8;
        double y = 0;
        //Act
        double result = _calculatorEngine.LogOfNumber(x, y);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void RootOfNumber_XRootY_ReturnsCorrectNumber()
    {
        //preq-UNIT-TEST-12
        //Arrange
        double ExpectedResult = 2;
        double x = 8;
        double y = 3;
        //Act
        double result = _calculatorEngine.RootOfNumber(x, y);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void Root_YValueIsEqualToZero_ReturnsInfinity()
    {
        //preq-UNIT-TEST-13
        //Arrange
        double ExpectedResult = Double.PositiveInfinity;
        double x = 8;
        double y = 0;
        //Act
        double result = _calculatorEngine.RootOfNumber(x, y);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void FactorialOfNumber_FactorialOfValue_ReturnsCorrectNumber()
    {
        //preq-UNIT-TEST-14
        //Arrange
        double ExpectedResult = 120;
        double x = 5;
        //Act
        double result = _calculatorEngine.FactorialOfNumber(x);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void Factorial_FactorialOfZero_ReturnsOne()
    {
        //preq-UNIT-TEST-15
        //Arrange
        double ExpectedResult = 1;
        double x = 0;
        //Act
        double result = _calculatorEngine.FactorialOfNumber(x);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void Sin_SinOf360Degrees_ReturnsCorrectNumber()
    {
        //preq-UNIT-TEST-16
        //Arrange
        double ExpectedResult = 0;
        double x = 360;
        //Act
        double result = _calculatorEngine.Sin(x);
        //Assert
        Assert.AreEqual(ExpectedResult, result, Tolerance);
    }

    [Test]
    public void Sin_SinOf90Degrees_ReturnsCorrectNumber()
    {
        //preq-UNIT-TEST-16
        //Arrange
        double ExpectedResult = 1;
        double x = 90;
        //Act
        double result = _calculatorEngine.Sin(x);
        //Assert
        Assert.AreEqual(ExpectedResult, result, Tolerance);
    }
    
    [Test]
    public void Cos_CosOf360Degrees_ReturnsCorrectNumber()
    {
        //preq-UNIT-TEST-17
        //Arrange
        double ExpectedResult = 1;
        double x = 360;
        //Act
        double result = _calculatorEngine.Cos(x);
        //Assert
        Assert.AreEqual(ExpectedResult, result, Tolerance);
    }
    
    [Test]
    public void Tan_TanOf360Degrees_ReturnsCorrectNumber()
    {
        //preq-UNIT-TEST-18
        //Arrange
        double ExpectedResult = 0;
        double x = 360;
        //Act
        double result = _calculatorEngine.Tan(x);
        //Assert
        Assert.AreEqual(ExpectedResult, result, Tolerance);
    }
    
    [Test]
    public void Tan_TanOf45Degrees_ReturnsCorrectNumber()
    {
        //preq-UNIT-TEST-18
        //Arrange
        double ExpectedResult = 1;
        double x = 45;
        //Act
        double result = _calculatorEngine.Tan(x);
        //Assert
        Assert.AreEqual(ExpectedResult, result, Tolerance);
    }
    
    [Test]
    public void Reciporcal_ReciporcalOfValue_ReturnsCorrectNumber()
    {
        //preq-UNIT-TEST-19
        //Arrange
        double ExpectedResult = 1.0 / 8.0;
        double x = 8;
        //Act
        double result = _calculatorEngine.Reciprocal(x);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void Reciporcal_ValueSetToZero_ReturnsInfinity()
    {
        //preq-UNIT-TEST-20
        //Arrange
        double ExpectedResult = double.PositiveInfinity;
        double x = 0;
        //Act
        double result = _calculatorEngine.Reciprocal(x);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
}