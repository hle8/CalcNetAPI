using CalcCommands;
using Microsoft.AspNetCore.Mvc;

namespace CalcNetAPI.Controllers;

[Route("[controller]/[action]")]
[ApiController]
public class CalculatorController : ControllerBase
{
    CalcCommand? _cmd;

    // Addition
    [HttpGet]
    public decimal Add(decimal firstNum, decimal secondNum)
    {
        _cmd = new AddCommand();
        return _cmd.Execute(firstNum, secondNum);
    }

    // Subtraction
    [HttpGet]
    public decimal Subtract(decimal firstNum, decimal secondNum)
    {
        _cmd = new SubtractCommand();
        return _cmd.Execute(firstNum, secondNum);
    }

    // Multiplication
    [HttpGet]
    public decimal Multiply(decimal firstNum, decimal secondNum)
    {
        _cmd = new MultiplyCommand();
        return _cmd.Execute(firstNum, secondNum);
    }

    // Division
    [HttpGet]
    public IActionResult Divide(decimal firstNum, decimal secondNum)
    {
        if (secondNum == 0)
        {
            return BadRequest("Cannot divide by zero.");
        }
        _cmd = new DivideCommand();
        return Ok(_cmd.Execute(firstNum, secondNum));
    }

    // Modulo
    [HttpGet]
    public IActionResult Modulo(decimal firstNum, decimal secondNum)
    {
        if (secondNum == 0)
        {
            return BadRequest("Cannot divide by zero.");
        }
        _cmd = new ModuloCommand();
        return Ok(_cmd.Execute(firstNum, secondNum));
    }
}
