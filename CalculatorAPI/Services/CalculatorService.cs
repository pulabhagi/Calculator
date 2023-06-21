using CalculatorAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculatorAPI.Services
{
    public class CalculatorService: ICalculatorService
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
    }

}