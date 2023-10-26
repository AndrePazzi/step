using System;

public class entregas{
    public static void Main(string[] args){
        int zona;
        double peso, costo;
        
        Console.WriteLine("Ingresar el peso del paquete (Kg)");
        peso = Convert.ToDouble(Console.ReadLine())*1000;
        
        if (peso>5000){
            Console.WriteLine("Limite de peso excedido");
        }else{
            
            Console.WriteLine("------MENU------\n\rIngresar la zona:\n\r[1] = NA\n\r[2] = CA\n\r[3] = SA\n\r[4] = EU\n\r[5] = AS");
            zona = Convert.ToInt16(Console.ReadLine());
            switch (zona){
            case 1: 
                costo = peso * 11;
                Console.WriteLine("El costo del paquete es: $" + costo);
                break;
            case 2: 
                costo = peso * 10;
                Console.WriteLine("El costo del paquete es: $" + costo);
                break;
            case 3: 
                costo = peso * 12;
                Console.WriteLine("El costo del paquete es: $" + costo);
                break;
            case 4: 
                costo = peso * 24;
                Console.WriteLine("El costo del paquete es: $" + costo);
                break;
            case 5: 
                costo = peso * 27;
                Console.WriteLine("El costo del paquete es: $" + costo);
                break;
            default: 
                Console.WriteLine("Error: La zona no es valida");
                break;
            }
        }
    }
}