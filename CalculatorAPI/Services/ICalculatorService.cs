﻿namespace CalculatorAPI.Controllers
{
    public interface ICalculatorService
    {
        int Add(int num1, int num2);
        int Subtract(int num1, int num2);
    }
}