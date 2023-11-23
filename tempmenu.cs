using System;

public class tempmenu{
    
    static double Celsius(double temp){
        return (temp - 32)/1.8;
    }
    
    static double Fahrenheit(double temp){
        return (temp * 1.8)+32;
    }
    
    public static void Main(string[] args){
        bool cont = true;
        
        while (cont == true){
            Console.WriteLine("Convertidor De Temperatura\n\rIngrese la temperatura que desee convertir");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar un numero dependiendo de la conversion que desee\n\r'1' [F -> C]\n\r'2' [C -> F]");
            int conv = Convert.ToInt32(Console.ReadLine());
            if (conv == 1){
                Console.WriteLine("La temperatura en Celsius es: " + Celsius(temp));
            }else if (conv == 2){
                Console.WriteLine("La temperatura en Fahrenheit es: " + Fahrenheit(temp));
            }else{
                Console.WriteLine("Opcion no valida");
            }
            
            Console.WriteLine("Desea realizar una conversion diferente? s/n");
            string lp = Console.ReadLine();
            if (lp == "n" || lp == "N"){
                cont = false;
            }
        }
    }
}