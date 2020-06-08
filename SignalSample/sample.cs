using System.Windows.Forms;

class sample : Form

{
    int data;
    public static void Main()
    {
       
        Application.Run(new sample());
    }
    public sample()
    {
        data = 6;
    }
}