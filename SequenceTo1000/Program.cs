using System;



class PSequenceTo1000
{
    static void Main()
    {
        for (int i = 2, b = 1; i <= 1002; i++, b++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(b + "-->" + i);
            }
            else
            {
                Console.WriteLine(b + "-->" + i * -1);
            }
        }
    }
}

