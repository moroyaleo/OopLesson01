using System.Collections.Generic;
using System.Drawing.Text;
using System.Windows.Forms;

class Stage : Form
{
    //ボールオブジェクト表示用   
    // private PictureBox pictureBoxBall = new PictureBox();
    //private Ball ball;
    private List<PictureBox> PictureBoxBalls = new List<PictureBox>();
    private List<Ball> balls = new List<Ball>();
    //タイマー
    private Timer timer = new Timer();
    public static void Main()
    {
        Application.Run(new Stage());

    }
    public Stage()
    {
        //フォームの設定
        Width = 1200;
        Height = 800;
        Text = "ボールシミュレーション";

        timer.Interval = 50;//ms
        timer.Tick += Timer_Tick;//時間経過で呼ぶメソッド

        this.MouseClick += Stage_MouseClick;
    }
    private void Stage_MouseClick(object sender, MouseEventArgs e)
    {
        //クリックした座標を使いボールオブジェクトを生成
        string path = "";
        if (e.Button == MouseButtons.Left)
        {
            path = @"images\tennisball_ball.png";
        }
        else if (e.Button == MouseButtons.Right)
        {
            path = @"images\download.png";
        }
        else
        {
            return;
        }
        //クリックした座標を使いボールオブジェクトを生成
        Ball ball = new Ball(e.X - 25, e.Y - 25, path);//ボールオブジェクトの生成
        balls.Add(ball);

        PictureBox pictureBoxBall = new PictureBox();
        pictureBoxBall.Width = 400;
        pictureBoxBall.Height = 400;
        pictureBoxBall.Left = (int)ball.YPos;
        pictureBoxBall.Top = (int)ball.XPos;
        pictureBoxBall.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBoxBall.Image = ball.Img;
        pictureBoxBall.Parent = this;

        pictureBoxBalls.Add(pictureBoxBall);

        timer.Start();//タイマースタート

        this.Text = "ボールシミュレーション" + Ball.Count;
       
    }
    //指定した時間が経過すると呼ばれるメソッド    
    private void Timer_Tick(object sender, System.EventArgs e)
    {
        for (int i = 0; i < balls.Count; i++)
        {


            balls[i].Move();
            pictureBoxBalls[i].Left = (int)balls[i].YPos;
            pictureBoxBall[i].Top = (int)balls[i].XPos;

        }
    }
}

   











