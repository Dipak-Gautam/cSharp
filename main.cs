using System;
using System.Collections;
class MainProgram
{
    public static void Main(string[] args){
        ArrayList mynumb = new ArrayList();
        mynumb = [1,2,3,4,5];
        Console.WriteLine("nuber :"+mynumb[1]);
        Console.WriteLine("length :" + mynumb.Count);
        mynumb.Add(6);
        Console.WriteLine("length :" + mynumb.Count);
        foreach(int items in mynumb){
            Console.Write("\t"+items);
        }
    }
}