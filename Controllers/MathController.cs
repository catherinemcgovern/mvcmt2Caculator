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
        [HttpPost]
        public IActionResult DoCalculation (MathOperation model)
        {

             if (model.Operator == "add")
      {
            {MyMathRoutines.Subtract(left, right)}"
            //model.LeftOperand + model.RightOperand =;
            return View(model);
      }
        

        
        else 
        {
            Console.WriteLine("Invalid Option");
            return View(model);
            
        }
/*  public decimal LeftOperand {get; set; }
        public string RightOperand {get; set; }
        public decimal Operator {get; set; }
        public decimal Result {get; set; } */

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
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
    }
}
