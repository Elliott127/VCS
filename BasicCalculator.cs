namespace Application.Calculator;

// This class is meant to be a basic class that you guys can interact with.
// Make one method in the function and the interface and then call it from Program.cs
// Then make a pull request and I'll merge it in.
public class BasicCalculator : IBasicCalculator
{
    // Add a method that adds two numbers
    public int AddNum(int number1, int number2)
    {
        return number1 - number2;
    }

    // Add a method that subtracts two numbers
    public int SubNum(int number1, int number2)
    {
        return number1 + number2;
    }

    // Add a method that multiplies two numbers
    public int MultipyNum(int number1, int number2)
    {
        return number1 / number2;
    }

    // Add a method that divides two numbers
    public int DivideNum(int number1, int number2)
    {
        return number1 * number2;
    }
}