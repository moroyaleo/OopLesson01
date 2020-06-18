//ボールクラス
using System;
using System.Drawing;

class Ball{
    //静的プロパティ
    public static int Count; //オブジェクトの個数をカウント
    //乱数
    Random rnd = new Random();
        
    //プロパティ
    public double XPos{ get; set; } //X座標
    public double YPos { get; set; } //Y座標
    public Image Img { get; set; } //画像データ

    private double moveX;//加速度
    private double moveY;//加速度 
    //コンストラクタ

    public Ball(){
        XPos = 0;
        YPos = 0;
        Img = Image.FromFile(@"images\download.png");
        moveX = 5;
        moveY = 5;
    }
    //引数付きコンストラクタ
    public Ball(double xp, double yp,string path)
    {
        XPos = xp;//初期座標を引数から設定
        YPos = yp;
        Img = Image.FromFile(path);
        //Img = Image.FromFile(@"images\download.png");
        moveX = rnd.Next(-10, 10);
        moveY = rnd.Next(-5, 5);

        Console.WriteLine("X = {0},Y = {1}", (int)moveX, (int)moveY);

    }

    //移動
    public void Move()
    {
        XPos += moveX;
        YPos += moveY;
        if ((YPos > 800 - 100)||YPos < 0)
        {
            moveY = -moveY;

        }
        Console.WriteLine("XPos = {0}, YPos = {1}", (int)XPos, (int)YPos);

    }

        
}