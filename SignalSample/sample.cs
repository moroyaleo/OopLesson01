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
        //stringの別名(エリアス)がString
        string moji = "";
        moji = Console.ReadLine();
        Console.WriteLine("文字列:" + moji.ToLower());
        Console.WriteLine("置換後:" + moji.Replace("bc","hijk"));










    }
}
