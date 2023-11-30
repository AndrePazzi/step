using System;

public class refarr {
    static int incrementarReferencia(ref int inc){
        inc = inc + 1;
        return inc;
    }
    
    public static void Main (string[] args) {
        int [] nums = new int [10];
        Random rand  = new Random();
        for(int i = 0; i < nums.Length; i++)
        {
            nums[i] = rand.Next(1, 20);
            Console.Write(nums[i] + " ");
            incrementarReferencia(ref nums[i]);
        }
        
        Console.WriteLine("\n\r");
        
        for(int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i] + " ");
        }
    }
}