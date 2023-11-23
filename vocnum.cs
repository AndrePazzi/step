using System;

public class vocnum{
    public static void Main(string[] args){
        string palabra;
        int letra = 0;
        int va = 0, ve = 0, vi = 0, vo = 0, vu = 0;
        
        Console.WriteLine("Ingrese una palabra:");
        palabra = Console.ReadLine();
        
        foreach (var c in palabra) {
            letra = (int) c;
            
            switch (letra){
                case 65:
                case 97:
                    va++;
                    break;
                
                case 69:
                case 101:
                    ve++;
                    break;
                    
                case 73:
                case 105:
                    vi++;
                    break;
                    
                case 79:
                case 111:
                    vo++;
                    break;
                    
                case 85:
                case 117:
                    vu++;
                    break;
                
            }
        }
        Console.WriteLine("La palabra contiene: \n\r " + va + " [ A ] \n\r " + ve + " [ E ] \n\r " + vi + " [ I ] \n\r " + vo + " [ O ] \n\r " + vu + " [ U ] \n\r ");
    }
}