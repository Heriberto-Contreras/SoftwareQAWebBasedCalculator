namespace CalculatorEngine;
using System;

public class CalculatorEngine
{
    public static void Main(string[] args)
    {
       
    }
    public double addition(double x, double y)
    {
        // preq-ENGINE-3
        return x + y;
    }

    public double subtraction(double x, double y)
    {
        // preq-ENGINE-4
        return x - y;
    }

    public double multiplication(double x, double y)
    {
        // preq-ENGINE-5
        return x * y;
    }

    public double division(double x, double y)
    {
        // preq-ENGINE-6
        return x / y;
    }

    public double equals(double x, double y)
    {
        // preq-ENGINE-7
        var precision = 8;
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
        return Math.Pow(x, y);
    }

    public double LogOfNumber(double x, double y)
    {
        return Math.Log(x, y);
    }

    public double RootOfNumber(double x, double y)
    {
        return Math.Pow(x, 1.0 / y);
    }

    public double FactorialOfNumber(double x)
    {
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

    public double sin(double x)
    {
        double number = x * (Math.PI / 180);
        Console.WriteLine(number);
    
        double result = Math.Sin(number);
    
        // Check if the result is within a tolerance of zero
        if (Math.Abs(result) < 1e-10) // You can adjust the tolerance level as needed
        {
            return 0.0; // Return exactly zero if the result is close enough to zero
        }
        else
        {
            return result; // Otherwise, return the actual result
        }
    }
 
    public double cos(double x)
    {
        return Math.Cos(x * (Math.PI / 180));
    }

    public double tan(double x)
    {
        return Math.Tan(x * (Math.PI / 180));
    }

    public double redciprocal(double x)
    {
        return 1 / x;
    }
}

