using CalcCommands;

namespace CalcCommandsTest;

[TestClass]
public class UnitTest1
{
    int numCase = 0;

    readonly int totalTests = 100_000 * 16;

    decimal left;
    decimal right;

    CalcCommand? cmd;

    [TestMethod]
    public void AddTest()
    {
        cmd = new AddCommand();

        for (var i = 0; i < totalTests; i++)
        {
            left = NumberGenerator((numCase & 1) != 0, (numCase & 2) != 0);
            right = NumberGenerator((numCase & 4) != 0, (numCase & 8) != 0);
            numCase = (numCase == 15) ? 0 : numCase + 1;
            Assert.AreEqual(left + right, cmd.Execute(left, right), $"Add | Left: {left} | Right: {right}");
        }
    }

    [TestMethod]
    public void SubtractTest()
    {
        cmd = new SubtractCommand();

        for (var i = 0; i < totalTests; i++)
        {
            left = NumberGenerator((numCase & 1) != 0, (numCase & 2) != 0);
            right = NumberGenerator((numCase & 4) != 0, (numCase & 8) != 0);
            numCase = (numCase == 15) ? 0 : numCase + 1;
            Assert.AreEqual(left - right, cmd.Execute(left, right), $"Subtract | Left: {left} | Right: {right}");
        }
    }

    [TestMethod]
    public void MultiplyTest()
    {
        cmd = new MultiplyCommand();

        for (var i = 0; i < totalTests; i++)
        {
            left = NumberGenerator((numCase & 1) != 0, (numCase & 2) != 0);
            right = NumberGenerator((numCase & 4) != 0, (numCase & 8) != 0);
            numCase = (numCase == 15) ? 0 : numCase + 1;
            Assert.AreEqual(left * right, cmd.Execute(left, right), $"Multiply | Left: {left} | Right: {right}");
        }
    }

    [TestMethod]
    public void DivideTest()
    {
        cmd = new DivideCommand();

        for (var i = 0; i < totalTests; i++)
        {
            left = NumberGenerator((numCase & 1) != 0, (numCase & 2) != 0);
            right = NumberGenerator((numCase & 4) != 0, (numCase & 8) != 0);
            numCase = (numCase == 15) ? 0 : numCase + 1;
            Assert.AreEqual(left / right, cmd.Execute(left, right), $"Divide | Left: {left} | Right: {right}");
        }
    }

    static decimal NumberGenerator(bool isNat, bool isNeg)
    {
        var rand = new Random();
        decimal num = 0;

        if (isNat)
            num = rand.Next();
        else
            num = (decimal)(rand.Next() + rand.NextDouble());

        if (isNeg)
            return 0 - num;
        else
            return num;
    }
}