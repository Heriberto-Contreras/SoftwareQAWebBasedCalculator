namespace CalculatorEngineUnitTests;
using CalculatorEngine;

public class Tests
{
    private CalculatorEngine _calculatorEngine;
    [SetUp]
    public void Setup()
    {
        _calculatorEngine = new CalculatorEngine();
    }

    [Test]
    public void MethodName_StateUnderTest_ExpectedBehavior()
    {
        //Arrange
        double ExpectedResult = 2.35;
        double x = 5.5;
        double y = -3.15;
        //Act
        double result = _calculatorEngine.addition(x, y);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }

    [Test]
    public void Subtraction()
    {
        //Arrange
        double ExpectedResult = 23.93;
        double x = 27.93;
        double y = 4;
        //Act
        double result = _calculatorEngine.subtraction(x, y);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void Multiplication()
    {
        //Arrange
        double ExpectedResult = 35.5;
        double x = 5;
        double y = 7.1;
        //Act
        double result = _calculatorEngine.multiplication(x, y);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void Division()
    {
        //Arrange
        double ExpectedResult = 3.0 / 9.0; //TODO I am pretty such that this is wrong lol!!!!!
        double x = 3.0;
        double y = 9.0;
        //Act
        double result = _calculatorEngine.division(x, y);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void Division_By_Zero()
    {
        //Arrange
        double ExpectedResult = double.PositiveInfinity;
        double x = 5;
        double y = 0;
        //Act
        double result = _calculatorEngine.division(x, y);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void Equals_One()
    {
        //Arrange
        double ExpectedResult = 1;
        double x = 0.333333;
        double y = 0.333333;
        //Act
        double result = _calculatorEngine.equals(x, y);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void Equals_Two()
    {
        //Arrange
        double ExpectedResult = 0;
        double x = 0.33333333;
        double y = 0.33333334;
        //Act
        double result = _calculatorEngine.equals(x, y);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void Equals_Three()
    {
        //Arrange
        double ExpectedResult = 1;
        double x = 0.333333331;
        double y = 0.333333332;
        //Act
        double result = _calculatorEngine.equals(x, y);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void Raise_Power()
    {
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
    public void Log()
    {
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
    public void Log_Error_One()
    {
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
    public void Log_Error_Two()
    {
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
    public void RootOfNumber()
    {
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
    public void Root_Error_One()
    {
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
    public void FactorialOfNumber()
    {
        //Arrange
        double ExpectedResult = 120;
        double x = 5;
        //Act
        double result = _calculatorEngine.FactorialOfNumber(x);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void Factorial_Convention()
    {
        //Arrange
        double ExpectedResult = 1;
        double x = 0;
        //Act
        double result = _calculatorEngine.FactorialOfNumber(x);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void Sin()
    {
        //Arrange
        double ExpectedResult = 0;
        double x = 360;
        //Act
        double result = _calculatorEngine.sin(x);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void Cos()
    {
        //Arrange
        double ExpectedResult = 1;
        double x = 360;
        //Act
        double result = _calculatorEngine.cos(x);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void Tan()
    {
        //Arrange
        double ExpectedResult = 0;
        double x = 360;
        //Act
        double result = _calculatorEngine.tan(x);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void Reciporcal()
    {
        //Arrange
        double ExpectedResult = 1.0 / 8.0;
        double x = 8;
        //Act
        double result = _calculatorEngine.redciprocal(x);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
    [Test]
    public void Reciporcal_Error()
    {
        //Arrange
        double ExpectedResult = double.PositiveInfinity;
        double x = 0;
        //Act
        double result = _calculatorEngine.redciprocal(x);
        //Assert
        Assert.AreEqual(ExpectedResult, result);
    }
    
}