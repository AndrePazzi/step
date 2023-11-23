using System;

public class operacion{
    static double Suma(double sum1, double sum2){
        return sum1 + sum2;
    }
    static double Resta(double res1, double res2){
        return res1 - res2;
    }
    static double Multiplicacion(double mul1, double mul2){
        return mul1 * mul2;
    }
    static double Division(double div1, double div2){
        if (div2 != 0){
            return div1 / div2;
        }else{
            return 0;
        }
    }
    
    
    public static void Main(string[] args){
        Console.WriteLine("Ingrese un numero");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("La suma es: " + Suma(num1, num2));
        Console.WriteLine("La resta es: " + Resta(num1, num2));
        Console.WriteLine("La multiplicacion es: " + Multiplicacion(num1, num2));
        if (Division(num1, num2) == 0){
            Console.WriteLine("No se puede dividir entre 0");
        }else{
            Console.WriteLine("La division es: " + Division(num1, num2));
        }
    }
}