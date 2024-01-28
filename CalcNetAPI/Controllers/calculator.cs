using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class calculator : ControllerBase
    {
        // Addition
        public decimal Add(decimal firstNum, decimal secondNum) => firstNum + secondNum;

        // Subtraction
        public decimal Subtract(decimal firstNum, decimal secondNum) => firstNum - secondNum;

        // Multiplication
        public decimal Multiply(decimal firstNum, decimal secondNum) => firstNum * secondNum;

        // Division
        public decimal Divide(decimal firstNum, decimal secondNum) => firstNum / secondNum;

        // Modulo
        public decimal Modulo(decimal firstNum, decimal secondNum) => firstNum % secondNum;
    }
}
