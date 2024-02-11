using CalcCommands;
using Microsoft.AspNetCore.Mvc;

namespace CalcNetAPI.Controllers;

[Route("[controller]/[action]")]
[ApiController]
public class CalculatorController : ControllerBase
{
    CalcCommand? cmd;

    // Addition
    public decimal Add(decimal firstNum, decimal secondNum)
    {
        cmd = new AddCommand();
        return cmd.Execute(firstNum, secondNum);
    }

    // Subtraction
    public decimal Subtract(decimal firstNum, decimal secondNum)
    {
        cmd = new SubtractCommand();
        return cmd.Execute(firstNum, secondNum);
    }

    // Multiplication
    public decimal Multiply(decimal firstNum, decimal secondNum)
    {
        cmd = new MultiplyCommand();
        return cmd.Execute(firstNum, secondNum);
    }

    // Division
    public decimal Divide(decimal firstNum, decimal secondNum)
    {
        cmd = new DivideCommand();
        return cmd.Execute(firstNum, secondNum);
    }

    // Modulo
    public decimal Modulo(decimal firstNum, decimal secondNum)
    {
        cmd = new ModuloCommand();
        return cmd.Execute(firstNum, secondNum);
    }
}
