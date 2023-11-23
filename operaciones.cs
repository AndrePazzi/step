using System;

public class operaciones{
    static double RealizarOperacion(double num1, double num2, double operacion){
        switch (operacion){
            case 1:
            return num1 + num2;
            break;
            
            case 2:
            return num1 - num2;
            break;
            
            case 3:
            return num1 * num2;
            break;
            
            case 4:
            return num1 / num2;
            break;
            
            default:
            return 0;
            break;
        }
    }
    public static void Main(string[] args){
        Console.WriteLine("Ingrese un numero");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escoja una operacion para realizar:\n\r[ 1 ] - Suma\n\r[ 2 ] - Resta\n\r[ 3 ] - Multiplicacion\n\r[ 4 ] - Division");
        int op = Convert.ToInt32(Console.ReadLine());
        if (op > 4 || op < 1){
            Console.WriteLine("Opcion no valida");
        }
        else if (num2 == 0 && op == 4){
            Console.WriteLine("No se puede dividir entre 0");
        }else{
            switch (op){
                case 1:
                Console.WriteLine("El resultado de la suma es: " + RealizarOperacion(num1, num2, op));
                break;
                
                case 2:
                Console.WriteLine("El resultado de la resta es: " + RealizarOperacion(num1, num2, op));
                break;
                
                case 3:
                Console.WriteLine("El resultado de la multiplicacion es: " + RealizarOperacion(num1, num2, op));
                break;
                
                case 4:
                Console.WriteLine("El resultado de la division es: " + RealizarOperacion(num1, num2, op));
                break;
            }
        }
    }
}