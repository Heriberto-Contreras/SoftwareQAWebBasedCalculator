using System.Diagnostics;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using CalculatorWebServerApp.Models;
using System.Text.RegularExpressions;

namespace CalculatorWebServerApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CalculatorEngine.CalculatorEngine _calculator;

        
        public HomeController(ILogger<HomeController> logger, CalculatorEngine.CalculatorEngine calculator)
        {
            _logger = logger;
            _calculator = calculator;
        }

        [HttpGet]
        public IActionResult Index(CalculatorModel model)
        {
            Console.WriteLine(model.OperandA);
            model.LabelResult = "Enter value(s) below and select an operation";
            return View(model);
        }
        public IActionResult Clear(CalculatorModel model)
        {
            //Clear Input A and B
            Console.WriteLine("Clear was called!");
            model.OperandA = "0";
            model.OperandB = "0";
            model.Result = 0;
            model.LabelResult = "Enter value(s) below and select an operation";
            return View("Index", model);
        }
        
        [HttpPost]
        public IActionResult Addition(CalculatorModel model)
        {
            //do the calculation
            Console.WriteLine("Addition was called!");
            if (String.IsNullOrEmpty(model.OperandA) ||
                String.IsNullOrEmpty(model.OperandB))
            {
                return View("ErrorStateTwo", model);
            }
            if (Regex.IsMatch(model.OperandA, @"[^0-9.-]") || 
                Regex.IsMatch(model.OperandB, @"[^0-9.-]")
                )
            {
                return View("ErrorStateTwo", model);
            }
            double x = Double.Parse(model.OperandA);
            double y = Double.Parse(model.OperandB);
            model.Result = _calculator.Addition(x, y);
            //successful state no errors here
            model.LabelResult = model.OperandA + " + " + model.OperandB + " = "; 
            return View("results", model);
        }
        public IActionResult Subtraction(CalculatorModel model)
        {
            //do the calculation
            Console.WriteLine("Subtraction was called!");
            if (String.IsNullOrEmpty(model.OperandA) ||
                String.IsNullOrEmpty(model.OperandB))
            {
                return View("ErrorStateTwo", model);
            }
            if (Regex.IsMatch(model.OperandA, @"[^0-9.-]") || 
                Regex.IsMatch(model.OperandB, @"[^0-9.-]")
               )
            {
                return View("ErrorStateTwo", model);
            }
            double x = Double.Parse(model.OperandA);
            double y = Double.Parse(model.OperandB);
            model.Result = _calculator.Subtraction(x, y);
            model.LabelResult = model.OperandA + " - " + model.OperandB + " = ";
            return View("results", model);
        }
        public IActionResult Multiplication(CalculatorModel model)
        {
            //do the calculation
            Console.WriteLine("Multiplication was called!");
            if (String.IsNullOrEmpty(model.OperandA) ||
                String.IsNullOrEmpty(model.OperandB))
            {
                return View("ErrorStateTwo", model);
            }
            if (Regex.IsMatch(model.OperandA, @"[^0-9.-]") || 
                Regex.IsMatch(model.OperandB, @"[^0-9.-]")
               )
            {
                return View("ErrorStateTwo", model);
            }
            double x = Double.Parse(model.OperandA);
            double y = Double.Parse(model.OperandB);
            model.Result = _calculator.Multiplication(x, y);
            model.LabelResult = model.OperandA + " * " + model.OperandB + " = ";
            return View("results", model);
        }
        public IActionResult Division(CalculatorModel model)
        {
            //do the calculation
            Console.WriteLine("Division was called!");
            if (String.IsNullOrEmpty(model.OperandA) ||
                String.IsNullOrEmpty(model.OperandB))
            {
                return View("ErrorStateTwo", model);
            }
            if (Regex.IsMatch(model.OperandA, @"[^0-9.-]") || 
                Regex.IsMatch(model.OperandB, @"[^0-9.-]")
               )
            {
                return View("ErrorStateTwo", model);
            }
            double x = Double.Parse(model.OperandA);
            double y = Double.Parse(model.OperandB);
            model.Result = _calculator.Division(x, y);
            if (model.Result == double.PositiveInfinity)
            {
                model.LabelResult = model.OperandA + " / " + model.OperandB + " = ";
                return View("ErrorState", model);
            }
            model.LabelResult = model.OperandA + " / " + model.OperandB + " = "; 
            return View("results", model);
        }
        public IActionResult Equals(CalculatorModel model)
        {
            //do the calculation
            Console.WriteLine("Equals was called!");
            if (String.IsNullOrEmpty(model.OperandA) ||
                String.IsNullOrEmpty(model.OperandB))
            {
                return View("ErrorStateTwo", model);
            }
            if (Regex.IsMatch(model.OperandA, @"[^0-9.-]") || 
                Regex.IsMatch(model.OperandB, @"[^0-9.-]")
               )
            {
                return View("ErrorStateTwo", model);
            }
            double x = Double.Parse(model.OperandA);
            double y = Double.Parse(model.OperandB);
            model.Result = _calculator.Equals(x, y);
            if (model.Result == 1)
            {
                model.LabelResult = "They are the same number!";
                return View("results", model);
            }
            model.LabelResult = "They are NOT the same number!"; 
            return View("results", model);
            
            
        }
        public IActionResult RaisePowerTo(CalculatorModel model)
        {
            //do the calculation
            Console.WriteLine("RaisePowerTo was called!");
            if (String.IsNullOrEmpty(model.OperandA) ||
                String.IsNullOrEmpty(model.OperandB))
            {
                return View("ErrorStateTwo", model);
            }
            if (Regex.IsMatch(model.OperandA, @"[^0-9.-]") || 
                Regex.IsMatch(model.OperandB, @"[^0-9.-]")
               )
            {
                return View("ErrorStateTwo", model);
            }
            double x = Double.Parse(model.OperandA);
            double y = Double.Parse(model.OperandB);
            model.Result = _calculator.RaiseToPower(x, y);
            model.LabelResult = model.OperandA + "^" + model.OperandB + " = ";
            return View("results", model);
        }
        public IActionResult LogOfNumber(CalculatorModel model)
        {
            //do the calculation
            Console.WriteLine("LogOfNumber was called!");
            if (String.IsNullOrEmpty(model.OperandA) ||
                String.IsNullOrEmpty(model.OperandB))
            {
                return View("ErrorStateTwo", model);
            }
            if (Regex.IsMatch(model.OperandA, @"[^0-9.-]") || 
                Regex.IsMatch(model.OperandB, @"[^0-9.-]")
               )
            {
                return View("ErrorStateTwo", model);
            }
            double x = Double.Parse(model.OperandA);
            double y = Double.Parse(model.OperandB);
            model.Result = _calculator.LogOfNumber(x, y);
            if (model.Result == double.NegativeInfinity)
            {
                model.LabelResult = model.OperandA + " log " + model.OperandB + " = ";
                return View("ErrorState", model);
            }
            if (model.Result == double.NaN)
            {
                model.LabelResult = model.OperandA + " log " + model.OperandB + " = ";
                return View("ErrorState", model);
            }
            model.LabelResult = model.OperandA + " log " + model.OperandB + " = ";
            return View("results", model);
        }
        public IActionResult RootOfNumber(CalculatorModel model)
        {
            //do the calculation
            Console.WriteLine("RootOfNumber was called!");
            if (String.IsNullOrEmpty(model.OperandA) ||
                String.IsNullOrEmpty(model.OperandB))
            {
                return View("ErrorStateTwo", model);
            }
            if (Regex.IsMatch(model.OperandA, @"[^0-9.-]") || 
                Regex.IsMatch(model.OperandB, @"[^0-9.-]")
               )
            {
                return View("ErrorStateTwo", model);
            }
            double x = Double.Parse(model.OperandA);
            double y = Double.Parse(model.OperandB);
            model.Result = _calculator.RootOfNumber(x, y);
            if (model.Result == double.NegativeInfinity)
            {
                model.LabelResult = model.OperandA + " root " + model.OperandB + " = ";
                return View("ErrorState", model);
            }
            model.LabelResult = model.OperandA + " root " + model.OperandB + " = ";
            return View("results", model);
        }       
        public IActionResult FactoricalOfNumber(CalculatorModel model)
        {
            //do the calculation
            if (String.IsNullOrEmpty(model.OperandA) ||
                String.IsNullOrEmpty(model.OperandB))
            {
                return View("ErrorStateTwo", model);
            }
            if (Regex.IsMatch(model.OperandA, @"[^0-9.-]") || 
                Regex.IsMatch(model.OperandB, @"[^0-9.-]")
               )
            {
                return View("ErrorStateTwo", model);
            }
            double x = Double.Parse(model.OperandA);
            Console.WriteLine("FactoricalOfNumber was called!");
            model.Result = _calculator.FactorialOfNumber(x);
            model.LabelResult = model.OperandA + "! = ";
            return View("results", model);
        }
        
        public IActionResult Sin(CalculatorModel model)
        {
            //do the calculation
            Console.WriteLine("Sin was called!");
            if (String.IsNullOrEmpty(model.OperandA) ||
                String.IsNullOrEmpty(model.OperandB))
            {
                return View("ErrorStateTwo", model);
            }
            if (Regex.IsMatch(model.OperandA, @"[^0-9.-]") || 
                Regex.IsMatch(model.OperandB, @"[^0-9.-]")
               )
            {
                return View("ErrorStateTwo", model);
            }
            double x = Double.Parse(model.OperandA);
            model.Result = _calculator.Sin(x);
            model.LabelResult = "sin(" + model.OperandA + ") = ";
            return View("results", model);
        }
        
        public IActionResult Cos(CalculatorModel model)
        {
            //do the calculation
            Console.WriteLine("Cos was called!");
            if (String.IsNullOrEmpty(model.OperandA) ||
                String.IsNullOrEmpty(model.OperandB))
            {
                return View("ErrorStateTwo", model);
            }
            if (Regex.IsMatch(model.OperandA, @"[^0-9.-]") || 
                Regex.IsMatch(model.OperandB, @"[^0-9.-]")
               )
            {
                return View("ErrorStateTwo", model);
            }
            double x = Double.Parse(model.OperandA);
            model.Result = _calculator.Cos(x);
            model.LabelResult = "cos(" + model.OperandA + ") = ";
            return View("results", model);
        }
        
        public IActionResult Tan(CalculatorModel model)
        {
            //do the calculation
            Console.WriteLine("Tan was called!");
            if (String.IsNullOrEmpty(model.OperandA) ||
                String.IsNullOrEmpty(model.OperandB))
            {
                return View("ErrorStateTwo", model);
            }
            if (Regex.IsMatch(model.OperandA, @"[^0-9.-]") || 
                Regex.IsMatch(model.OperandB, @"[^0-9.-]")
               )
            {
                return View("ErrorStateTwo", model);
            }
            double x = Double.Parse(model.OperandA);
            model.Result = _calculator.Tan(x);
            model.LabelResult = "tan(" + model.OperandA + ") = ";
            return View("results", model);
        }
        
        public IActionResult Reciprocal(CalculatorModel model)
        {
            //do the calculation
            Console.WriteLine("Reciprocal was called!");
            if (String.IsNullOrEmpty(model.OperandA) ||
                String.IsNullOrEmpty(model.OperandB))
            {
                return View("ErrorStateTwo", model);
            }
            if (Regex.IsMatch(model.OperandA, @"[^0-9.-]") || 
                Regex.IsMatch(model.OperandB, @"[^0-9.-]")
               )
            {
                return View("ErrorStateTwo", model);
            }
            double x = Double.Parse(model.OperandA);
            model.Result = _calculator.Reciprocal(x);
            if (model.Result == double.PositiveInfinity)
            {
                model.LabelResult = "1 / " + model.OperandA + " = ";
                return View("ErrorState", model);
            }
            model.LabelResult = "1 / " + model.OperandA + " = ";
            return View("results", model);
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}