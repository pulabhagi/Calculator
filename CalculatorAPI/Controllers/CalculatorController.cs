using CalculatorAPI.Models;
using CalculatorAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculatorAPI.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly CalculatorService _calculatorService;

        public CalculatorController()
        {
            _calculatorService = new CalculatorService();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(int operand1, int operand2)
        {
            int result = _calculatorService.Add(operand1, operand2);           
            return Json(result);
        }

        [HttpPost]
        public ActionResult Subtract(int operand1, int operand2)
        {
            int result = _calculatorService.Subtract( operand1,  operand2);
            return Json(result);
        }
    }


}