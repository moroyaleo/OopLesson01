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
        int num;
        Random rnd = new Random();
        var checkNum = new int[20] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        for (int i = 0; i < 20; i++)
        {
            do
            {
                num = rnd.Next(20) + 1;

            } while (checkNum[num - 1] != 0);
            checkNum[num - 1] = 1;
            Console.Write(num + " ");
        }
        }
    }












    

