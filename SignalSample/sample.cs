﻿using System;
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
            Console.WriteLine("文字列:" + moji.ToUpper());
             Console.WriteLine("文字数:" + moji.Length);
            
        
        
           

        


    }
}
