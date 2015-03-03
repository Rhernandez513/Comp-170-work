using System;
static class Overflow
{    
    static void Main()
    {
        int x, y, sum, pos;
        x = int.MaxValue;
        y = 2;
        sum = x + y;
        pos = -sum;
        Console.WriteLine(pos);
    }
}
