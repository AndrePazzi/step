using System;

public class p1 {
    public static void Main (string[] args) {
        Console.WriteLine("Ingresa el valor de la primera variable");
        bool v1 = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Ingresa el valor de la segunda variable");
        bool v2 = Convert.ToBoolean(Console.ReadLine());
        bool r1 = (v1 && v1) || (v2 && v1);
        bool r2 = (v1 || v2) && (v1 || v1);
        bool r3 = !(v1 && v2);
        Console.WriteLine("Resultado 1) " + r1);
        Console.WriteLine("Resultado 2) " + r2);
        Console.WriteLine("Resultado 3) " + r3);
        
    }
}


