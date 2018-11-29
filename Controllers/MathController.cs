using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MT2MathCaculator.Models;
using MathLibrary;

namespace MT2MathCaculator.Controllers
{
    public class MathController : Controller
    {


                public IActionResult Calculator (MathOperation model)
                    {
                        return View(model);

                    }

        public IActionResult Index()
        {
            string message = "this is the message";
            ViewData["Message"] = message;
            return View();
        }

        [HttpPost]
        public IActionResult DoCalculation (MathOperation model)
        {

           
            if (model.Operator == "+")
            {
                MyMathRoutines.Add(model.LeftOperand, model.RightOperand);
                return View(model);
            }
            else if (model.Operator == "-")
            {
                MyMathRoutines.Subtract(model.LeftOperand, model.RightOperand);
                return View(model);
            }

            else if (model.Operator == "*")
            {
                MyMathRoutines.Multiply(model.LeftOperand, model.RightOperand);
                return View(model);
            }

            else if (model.Operator == "/")
            {
                MyMathRoutines.Divide(model.LeftOperand, model.RightOperand);
                return View(model);
            }
                        
            else 
            {
                Console.WriteLine("Invalid Option");
                return View(model);
                
            }
        }
    }
}


/*  public decimal LeftOperand {get; set; }
        public string RightOperand {get; set; }
        public decimal Operator {get; set; }
        public decimal Result {get; set; } */

/*
            ViewData["LeftOperand"] = left;
            ViewData["RightOperand"] = right;
            ViewData["AddResult"] = $"{left} plus {right} is: {MyMathRoutines.Add(left, right)}";
            return View(); */

        /*      if (model.ConversionType == "meters-to-feet")
      {
            model.ConvertedValue = model.ValueToConvert * 3.28084m;
            return View(model);
      }
        
       else if (model.ConversionType == "feet-to-meters")
        {
            model.ConvertedValue = model.ValueToConvert * 0.3048m;
            return View(model);
            
        } 

       else if (model.ConversionType == "pounds-to-ounces")
        {
            model.ConvertedValue = model.ValueToConvert * 16m;
            return View(model);
            
        }

        
       else if (model.ConversionType == "ounces-to-pounds")
        {
            model.ConvertedValue = model.ValueToConvert * 0.0625m;
            return View(model);
            
        } */
