using System;
using System.Collections;

class MainProgram{
    public static void Main(string [] args)
    {
        ArrayList Numbers = new ArrayList();
        Console.WriteLine("enter ten numbers");
        for(int i=0;i<10;i++)
        {
            double temp = Convert.ToDouble(Console.ReadLine());
            Numbers.Add(temp);
        }
        Numbers.Sort();
        Console.WriteLine("the shoetred numbers are :" );
        foreach (var item in Numbers)
        {
            Console.Write(item +"\t");
        }
    }
}