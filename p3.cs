using System;

public class p3 {
    public static void Main (string[] args) {
        double x = 3*(4+ Math.Pow(7, 2))+3/1-45;
        double A = 5+(2+ Math.Pow(8, 2))+9/3-15;
        bool r3 = (Math.Pow(5, 2)) > (16/3);
        bool r4 = (Math.Pow(2, 2)) >= (3+2);
        bool r5 = (1*3+5) > (3+3) && (3+1) < (5*6+3);
        Console.WriteLine("Resultado 1) " + x);
        Console.WriteLine("Resultado 2) " + A);
        Console.WriteLine("Resultado 3) " + r3);
        Console.WriteLine("Resultado 4) " + r4);
        Console.WriteLine("Resultado 5) " + r5);
    }
}
