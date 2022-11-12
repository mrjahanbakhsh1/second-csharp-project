using System;
class myProgram
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("Give Me Three sides");
        string num1 = Console.ReadLine();
        int a = Convert.ToInt32(num1);

        string num2 = Console.ReadLine();
        int b = Convert.ToInt32(num2);

        string num3 = Console.ReadLine();
        int c = Convert.ToInt32(num3);

        if(a+b>c && b+c>a && a+c>b) {
            Mohit(a, b, c);
        } else {
            Console.WriteLine("NO Mosals!");
        }
    }

    private static void Mohit(int x, int y, int z) {
        float myMohit = x+y+z;
        Console.WriteLine("Mohit is : " + myMohit);
    }
}
// craeted by Mohammad reza jahanbakhsh
