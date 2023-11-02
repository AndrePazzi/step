using System;

public class bisiesto{
    public static void Main(string[] args){
        int anio;
        bool bis = false;
        
        Console.WriteLine("Ingrese un año");
        anio = Convert.ToInt32(Console.ReadLine());
        
        if (anio%4 == 0 && anio%100 != 0){
            bis = true;
        }else if (anio%100 == 0 && anio%400 == 0){
            bis = true;
        }
        
        if (bis == true){
            Console.WriteLine("es bisiesto");
        }else{
            Console.WriteLine("no es bisiesto");
        }
    }
}