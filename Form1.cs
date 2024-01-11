namespace WinForms_240111_animacjaPictureBox_LeftTop
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      pictureBox1.Size= new Size(50,50);
      pictureBox1.Location= new Point(
        this.Width/3, this.Height/3 );
      KeyPreview = true;
    }

    private void pictureBox1_Paint(object sender, PaintEventArgs e)
    {
      e.Graphics.Clear(Color.YellowGreen);
    }

    private void buttonPoczatek_Click(object sender, EventArgs e)
    {
      pictureBox1.Location = new Point(
        this.Width / 3, this.Height / 3);
    }

    private void buttonLewo_Click(object sender, EventArgs e)
    {
      int x =pictureBox1.Location.X;
      if (x>50) x -= 50;
      pictureBox1.Left = x;
    }

    private void buttonPrawo_Click(object sender, EventArgs e)
    {
      //Right odleg³oœæ miêdzy praw¹ krawêdzi¹ pictureBox1
      //a lew¹ krawêdzi¹ Form1
      int x = pictureBox1.Location.X;
      if (pictureBox1.Right < this.Width-50) x += 50;
      pictureBox1.Left = x;
    }

    private void buttonGora_Click(object sender, EventArgs e)
    {
      int y = pictureBox1.Location.Y;
      if (y > 50) y -= 50;
      pictureBox1.Top = y;
    }

    private void buttonDol_Click(object sender, EventArgs e)
    {
      int y = pictureBox1.Location.Y;
      if (y+pictureBox1.Height < this.Height-50 ) y += 50;
      pictureBox1.Top = y;
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      int x = pictureBox1.Location.X;
      int y = pictureBox1.Location.Y;

      if (e.KeyCode == Keys.D) x += 1;
      else if (e.KeyCode == Keys.A) x -= 1;
      else if (e.KeyCode == Keys.W) y -= 1;
      else if (e.KeyCode == Keys.S) y += 1;

      pictureBox1.Location = new Point(x, y);
    }






  }
}