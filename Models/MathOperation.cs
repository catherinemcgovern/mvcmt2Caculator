using System;

namespace MT2MathCaculator.Models
{
    public class MathOperation
    {
        public decimal LeftOperand {get; set; }
        public string RightOperand {get; set; }
        public decimal Operator {get; set; }
        public decimal Result {get; set; }
    }
}