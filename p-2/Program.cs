using System;
class myProgram
{
    public static void Main(string[] args) 
    {
        string num1 = Console.ReadLine();
        double x = Convert.ToDouble(num1);

        string num2 = Console.ReadLine();
        double y = Convert.ToDouble(num2);

        double xyMinus = Math.Abs(x-y);
        double yAbs = Math.Abs(y);

        double xyPow = Math.Pow(xyMinus, yAbs);
        double answer = Math.Sqrt(xyPow);

        Console.WriteLine(answer);
    }
}
// craeted by Mohammad reza jahanbakhsh
