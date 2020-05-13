
namespace BlazorCalculator.Data
{
    public interface ICalculatorService
    {
        int Add(int value1, int value2);

        int Subtract(int value1, int value2);

        int Multiply(int value1, int value2);

        int Divide(int value1, int value2);
    }
}
