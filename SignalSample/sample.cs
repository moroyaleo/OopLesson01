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
        

        var str = "";

        str = Console.ReadLine();
        var city = str.Split(',');
       
        for (int i = 0; i < city.Length; i++)
        {
            Console.Write("群馬県");
            Console.WriteLine(city[i] + "市");
        }












    }
}
