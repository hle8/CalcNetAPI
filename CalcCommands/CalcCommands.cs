namespace CalcCommands;

public class CalcCommand
{
    public virtual decimal Execute(decimal left, decimal right)
    {
        return 0m;
    }
}

public class AddCommand : CalcCommand
{
    public override decimal Execute(decimal left, decimal right)
    {
        return left + right;
    }
}

public class SubtractCommand : CalcCommand
{
    public override decimal Execute(decimal left, decimal right)
    {
        return left - right;
    }
}

public class MultiplyCommand : CalcCommand
{
    public override decimal Execute(decimal left, decimal right)
    {
        return left * right;
    }
}

public class DivideCommand : CalcCommand
{
    public override decimal Execute(decimal left, decimal right)
    {
        return left / right;
    }
}

public class ModuloCommand : CalcCommand
{
    public override decimal Execute(decimal left, decimal right)
    {
        return left % right;
    }
}