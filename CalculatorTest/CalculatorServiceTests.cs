using CalculatorAPI.Controllers;
using CalculatorAPI.Services;
using System.Web.Mvc;
using NUnit.Framework;

namespace CalculatorAPI.Tests
{
    [TestFixture]
    public class CalculatorControllerTests
    {
        private CalculatorController _controller;

        [SetUp]
        public void Setup()
        {
            _controller = new CalculatorController();
        }

        [Test]
        public void Add_Action_Returns_JsonResult()
        {
            // Arrange
            int operand1 = 2;
            int operand2 = 3;

            // Act
            ActionResult result = _controller.Add(operand1, operand2);

            // Assert
            Assert.IsInstanceOf<JsonResult>(result);
        }

        [Test]
        public void Subtract_Action_Returns_JsonResult()
        {
            // Arrange
            int operand1 = 5;
            int operand2 = 3;

            // Act
            ActionResult result = _controller.Subtract(operand1, operand2);

            // Assert
            Assert.IsInstanceOf<JsonResult>(result);
        }
    }
}
