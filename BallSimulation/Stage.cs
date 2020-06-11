using System.Windows.Forms;

class Stage : Form
{
    public static void Main()
    {
        Application.Run(new Stage());

    }
    public Stage () {
        Width = 1200;
        Height = 800;
        Text = "ボールシミュレーション";


    }

    
}