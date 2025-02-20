namespace CodeCovDemo.Core.Tests;

public class CalculatorTests {
    [Fact]
    public void AddTest() {
        var calculator = new Calculator();
        var result = calculator.Add(1, 2);
        result.ShouldBe(3);
    }
}
