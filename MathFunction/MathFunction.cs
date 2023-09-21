
namespace MathFunction;

public class MathFormula
{
    public static float SquareArea(float number1, float number2)
    {
        return number1 * number2;
    }

    public static float TriangleArea(float b, float h)
    {
        return 0.5f * b * h;
    }

    public static float CircleArea(float r)
    {
        return (float)Math.PI * (float)Math.Pow(r, 2);
    }


}
