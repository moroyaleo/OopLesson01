using System;
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

        var scores = new int[5];
        int num = 0;
        //scores[0] = 10;
        //scores[1] = 20;
        //scores[2] = 30;
        //scores[3] = 40;
        //scores[4] = 50;
        
       
        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine("scores["+i+"] = ");
            scores[i] = int.Parse(Console.ReadLine());


        }
        for (int i = 0; i < scores.Length; i++)
            num += scores[i];

        {
            Console.WriteLine("入力された値の合計は"+num+"です。" );
        }

    }
}