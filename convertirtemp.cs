using System;

public class convertirtemp{
    public static void Main(string[] args){
        int grad;
        double temp, conv = 0;
        
        
        Console.WriteLine("Convertidor De Temperatura");
        Console.WriteLine(" ");
        Console.WriteLine("Ingresar un numero dependiendo de la conversion que desee");
        Console.WriteLine("'1' [F -> C]");
        Console.WriteLine("'2' [C -> F]");
        grad = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Ingresar temperatura");
        temp = Convert.ToDouble(Console.ReadLine());
        if (grad == 1){
            conv = (temp - 32)/1.8;
            Console.WriteLine("La temperatura en C es: " + conv);
        }else if (grad == 2){
            conv = (temp * 1.8)+32;
            Console.WriteLine("La temperatura en F es: " + conv);
        }else{
            Console.WriteLine("Error: Tipo de temperatura no valido");
        }
        
    }
}