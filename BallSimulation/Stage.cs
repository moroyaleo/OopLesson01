using System.Drawing.Text;
using System.Windows.Forms;

class Stage : Form {
    private PictureBox pictureBoxBall = new PictureBox();
    private Ball ball;

    private Timer timer = new Timer();
    public static void Main()
    {
        Application.Run(new Stage());

    }
    public Stage() {
        Width = 1200;
        Height = 800;
        Text = "ボールシミュレーション";

        ball = new Ball();
        
        pictureBoxBall.Width = 100;
        pictureBoxBall.Height = 100;
        pictureBoxBall.Top = (int)ball.YPos;
        pictureBoxBall.Left = (int)ball.XPos;
        pictureBoxBall.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBoxBall.Image = ball.Img;
        pictureBoxBall.Parent = this;

        timer.Interval = 10; //ms
        timer.Tick += Timer_Tick;
        timer.Start();
    }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            ball.Move();
            pictureBoxBall.Top = (int)ball.YPos;
            pictureBoxBall.Left = (int)ball.XPos;

        }
    }


    
