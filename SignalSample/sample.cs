using System;
using System.Runtime.Remoting.Metadata;
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
      
       
        
       
        for (int i = 0; i < scores.Length; i++)
        {
            Console.Write("scores["+i+"] = ");
            scores[i] = int.Parse(Console.ReadLine());


        }
        Console.WriteLine();

        for (int j = 0; j < scores.Length; j++)


        {
            //アスタリスク出力
            for (int i = 0; i < scores[j]; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();//改行
        }

    }
}