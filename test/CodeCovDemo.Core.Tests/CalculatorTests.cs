namespace CodeCovDemo.Core.Tests;

public class CalculatorTests {
    [Fact]
    public void AddTest() {
        var calculator = new Calculator();
        var result = calculator.Add(1, 2);
        result.ShouldBe(3);
    }

    [Fact]
    public void SubtractTest() {
        var calculator = new Calculator();
        var result = calculator.Subtract(3, 2);
        result.ShouldBe(1);
    }

    [Fact]
    public void MultiplyTest() {
        var calculator = new Calculator();
        var result = calculator.Multiply(2, 3);
        result.ShouldBe(6);
    }

    [Fact]
    public void DivideByZeroTest() {
        var calculator = new Calculator();
        Action act = () => calculator.Divide(6, 0);
        act.ShouldThrow<DivideByZeroException>();
    }
}
