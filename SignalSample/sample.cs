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

        int step;

        Console.Write("段数: ");
        step = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int j = 0; j < step; j++)
        {
            for(int i = step-1;i>( j-1);i--)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < (j + 1); i++)
            {
                Console.Write("＊");
            }

            Console.WriteLine();
        }


    }
}
