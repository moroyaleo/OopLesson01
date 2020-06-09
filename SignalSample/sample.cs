using System;
using System.Globalization;
using System.Windows.Forms;

class Sample : Form

{
    int data;
    public static void Main()
    {

        Application.Run(new Sample());
    }
    public Sample()
    {
        Random rnd = new Random();
        Console.Write("①");
        Console.WriteLine(rnd.Next(101));

        Console.Write("②");
        for (int i = 0; i < 20; i++)
        {
            Console.Write(rnd.Next(20) + 1 + " ");
        }
    }












    }

