using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculatorAPI.Models
{
    public class CalculatorModel
    {
        public int Operand1 { get; set; }
        public int Operand2 { get; set; }
        public int Result { get; set; }

        public int Add()
        {
            Result = Operand1 + Operand2;
            return Result;
        }

        public int Subtract()
        {
            Result = Operand1 - Operand2;
            return Result;
        }
    }
}