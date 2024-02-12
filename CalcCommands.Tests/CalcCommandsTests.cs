namespace CalcCommands.Tests;

public class CalcCommandsTests
{
    CalcCommand? _cmd;

    [Theory]
    [InlineData("0", "1")]
    [InlineData("1", "3")]
    [InlineData("0", "1.1")]
    public void AddCommand_ReturnsPositiveNumber(string l, string r)
    {
        decimal left = Decimal.Parse(l);
        decimal right = Decimal.Parse(r);
        _cmd = new AddCommand();

        var result = _cmd.Execute(left, right) > 0;

        Assert.True(result);
    }

    [Theory]
    [InlineData("0", "-1")]
    [InlineData("1", "-3")]
    [InlineData("0", "-1.1")]
    public void AddCommand_ReturnsNegativeNumber(string l, string r)
    {
        decimal left = Decimal.Parse(l);
        decimal right = Decimal.Parse(r);
        _cmd = new AddCommand();

        var result = _cmd.Execute(left, right) < 0;

        Assert.True(result);
    }

    [Theory]
    [InlineData("0", "0")]
    [InlineData("1", "-1")]
    [InlineData("1.1", "-1.1")]
    public void AddCommand_ReturnsZero(string l, string r)
    {
        decimal left = Decimal.Parse(l);
        decimal right = Decimal.Parse(r);
        _cmd = new AddCommand();

        var result = _cmd.Execute(left, right) == 0;

        Assert.True(result);
    }

    [Theory]
    [InlineData("1", "0")]
    [InlineData("2", "-1")]
    [InlineData("1.11", "1.1")]
    public void SubtractCommand_ReturnsPositiveNumber(string l, string r)
    {
        decimal left = Decimal.Parse(l);
        decimal right = Decimal.Parse(r);
        _cmd = new SubtractCommand();

        var result = _cmd.Execute(left, right) > 0;

        Assert.True(result);
    }

    [Theory]
    [InlineData("0", "1")]
    [InlineData("1", "2")]
    [InlineData("-2", "1")]
    [InlineData("1.1", "1.11")]
    public void SubtractCommand_ReturnsNegativeNumber(string l, string r)
    {
        decimal left = Decimal.Parse(l);
        decimal right = Decimal.Parse(r);
        _cmd = new SubtractCommand();

        var result = _cmd.Execute(left, right) < 0;

        Assert.True(result);
    }

    [Theory]
    [InlineData("0", "0")]
    [InlineData("1", "1")]
    [InlineData("-2", "-2")]
    [InlineData("1.1", "1.1")]
    [InlineData("-1.1", "-1.1")]
    public void SubtractCommand_ReturnsZero(string l, string r)
    {
        decimal left = Decimal.Parse(l);
        decimal right = Decimal.Parse(r);
        _cmd = new SubtractCommand();

        var result = _cmd.Execute(left, right) == 0;

        Assert.True(result);
    }

    [Theory]
    [InlineData("1", "2")]
    [InlineData("-2", "-1")]
    [InlineData("1.11", "1.1")]
    [InlineData("-1.11", "-1.1")]
    public void MultiplyCommand_ReturnsPositiveNumber(string l, string r)
    {
        decimal left = Decimal.Parse(l);
        decimal right = Decimal.Parse(r);
        _cmd = new MultiplyCommand();

        var result = _cmd.Execute(left, right) > 0;

        Assert.True(result);
    }

    [Theory]
    [InlineData("1", "-1")]
    [InlineData("-2", "1")]
    [InlineData("-1.1", "1.11")]
    [InlineData("1.1", "-1.11")]
    public void MultiplyCommand_ReturnsNegativeNumber(string l, string r)
    {
        decimal left = Decimal.Parse(l);
        decimal right = Decimal.Parse(r);
        _cmd = new MultiplyCommand();

        var result = _cmd.Execute(left, right) < 0;

        Assert.True(result);
    }

    [Theory]
    [InlineData("0", "0")]
    [InlineData("1", "0")]
    [InlineData("-2", "0")]
    [InlineData("0", "1.1")]
    [InlineData("-1.1", "0")]
    public void MultiplyCommand_ReturnsZero(string l, string r)
    {
        decimal left = Decimal.Parse(l);
        decimal right = Decimal.Parse(r);
        _cmd = new MultiplyCommand();

        var result = _cmd.Execute(left, right) == 0;

        Assert.True(result);
    }

    [Theory]
    [InlineData("1", "2")]
    [InlineData("-2", "-1")]
    [InlineData("1.11", "1.1")]
    [InlineData("-1.11", "-1.1")]
    public void DivideCommand_ReturnsPositiveNumber(string l, string r)
    {
        decimal left = Decimal.Parse(l);
        decimal right = Decimal.Parse(r);
        _cmd = new DivideCommand();

        var result = _cmd.Execute(left, right) > 0;

        Assert.True(result);
    }

    [Theory]
    [InlineData("1", "-1")]
    [InlineData("-2", "1")]
    [InlineData("-1.1", "1.11")]
    [InlineData("1.1", "-1.11")]
    public void DivideCommand_ReturnsNegativeNumber(string l, string r)
    {
        decimal left = Decimal.Parse(l);
        decimal right = Decimal.Parse(r);
        _cmd = new DivideCommand();

        var result = _cmd.Execute(left, right) < 0;

        Assert.True(result);
    }

    [Theory]
    [InlineData("0", "1")]
    [InlineData("0", "-3")]
    [InlineData("0", "1.1")]
    [InlineData("0", "-1.11")]
    public void DivideCommand_ReturnsZero(string l, string r)
    {
        decimal left = Decimal.Parse(l);
        decimal right = Decimal.Parse(r);
        _cmd = new DivideCommand();

        var result = _cmd.Execute(left, right) == 0;

        Assert.True(result);
    }
}