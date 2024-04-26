namespace CalculatorEngine;
using System;

public class CalculatorEngine
{
    public static void Main(string[] args)
    {
       
    }
    public double Addition(double x, double y)
    {
        //preq-ENGINE-3
        return x + y;
    }

    public double Subtraction(double x, double y)
    {
        //preq-ENGINE-4
        return x - y;
    }

    public double Multiplication(double x, double y)
    {
        //preq-ENGINE-5
        return x * y;
    }

    public double Division(double x, double y)
    {
        //preq-ENGINE-7
        return x / y;
    }

    public double Equals(double x, double y)
    {
        //preq-ENGINE-8
        var precision = 9;
        var tolerance = Math.Pow(10, -precision); // 10000000
        var absoluteValueOfDiff = Math.Abs(x - y); 
        var isWithinTolerance = absoluteValueOfDiff <= tolerance;
        if (isWithinTolerance)
        {
            return 1;
        }
        return 0;
    }

    public double RaiseToPower(double x, double y)
    {
        //preq-ENGINE-9
        return Math.Pow(x, y);
    }

    public double LogOfNumber(double x, double y)
    {
        //preq-ENGINE-10
        return Math.Log(x, y);
    }

    public double RootOfNumber(double x, double y)
    {
        //preq-ENGINE-11
        return Math.Pow(x, 1.0 / y);
    }

    public double FactorialOfNumber(double x)
    {
        //preq-ENGINE-12
        double result = 1;
        for(int i = 0; i < Math.Abs(x); i++)
        {
            result *= Math.Abs(x) - i;
        }
        
        if (x < 0)
        {
            return -result;
        }
        return result;
    }

    public double Sin(double x)
    {
        //preq-ENGINE-13
        return Math.Sin(x * (Math.PI / 180));
    }
 
    public double Cos(double x)
    {
        //preq-ENGINE-14
        return Math.Cos(x * (Math.PI / 180));
    }

    public double Tan(double x)
    {
        //preq-ENGINE-15
        return Math.Tan(x * (Math.PI / 180));
    }

    public double Reciprocal(double x)
    {
        //preq-ENGINE-16
        return 1 / x;
    }
}

