using System;

public class prom10 {
    public static void Main (string[] args) {
        float cal1, cal2, cal3, cal4, promedio;
        
        Console.WriteLine("Ingresar calificacion 1");
        cal1 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Ingresar calificacion 2");
        cal2 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Ingresar calificacion 3");
        cal3 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Ingresar calificacion 4");
        cal4 = Convert.ToSingle(Console.ReadLine());
        promedio = (cal1 + cal2 + cal3 + cal4)/4;
        if (promedio >= 9.5){
            Console.WriteLine("El promedio es: 10");
        }else{
            Console.WriteLine("El promedio es: " + promedio);
        }
    }
}