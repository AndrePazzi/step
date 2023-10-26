using System;

public class astdesc{
    public static void Main(string[] args){
        for (int i = 10; i>=0; i--){
            for (int j=1; j<=i;j++){ 
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}