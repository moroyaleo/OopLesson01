//ボールクラス
using System.Drawing;

class Ball{
    //プロパティ
    public double XPos{ get; set; } //X座標
    public double YPos { get; set; } //Y座標
    public Image Img { get; set; } //画像データ

    //コンストラクタ
    public Ball(){
        XPos = 0;
        YPos = 0;
        Img = Image.FromFile("image\\soccer_ball.png");

    }
}