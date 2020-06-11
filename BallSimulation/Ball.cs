﻿//ボールクラス
using System.Drawing;

class Ball{
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
        Img = Image.FromFile(@"images\soccer_ball.png");
        moveX = 5;
        moveY = 5;
    }
    public void Move()
    {
        XPos += moveX;
        YPos += moveY;
    }
        
}