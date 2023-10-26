using System;

public class p2 {
    public static void Main (string[] args) {
        bool x1 = true;
        bool x2 = true;
        bool x3 = false;
        bool x4 = false;
        bool y1 = true;
        bool y2 = false;
        bool y3 = true;
        bool y4 = false;
        bool not1 = !x1;
        bool not2 = !x2;
        bool not3 = !x3;
        bool not4 = !x4;
        bool and1 = not1 && y1;
        bool and2 = not2 && y2;
        bool and3 = not3 && y3;
        bool and4 = not4 && y4;
        Console.WriteLine("Resultados '!x': " + not1 + ", " + not2 + ", " + not3 + ", " + not4);
        Console.WriteLine("Resultados '!x && Y': " + and1 + ", " + and2 + ", " + and3 + ", " + and4);
        
    }
}


