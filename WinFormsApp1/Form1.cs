namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x = 0;//up 1 down 2 left 3 right 4

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            pictureBox2.Visible = false;
            timer1.Interval = 100;
            switch (e.KeyCode)
            {
                case Keys.Up:
                    pictureBox1.Image = Image.FromFile("tank1.gif");
                    pictureBox1.Top -= 5;
                    pictureBox2.Top = pictureBox1.Top - 30;
                    pictureBox2.Left = pictureBox1.Left + 30;
                    x = 1;
                    break;
                case Keys.Down:
                    pictureBox1.Image = Image.FromFile("tank3.gif");
                    pictureBox1.Top += 5;
                    pictureBox2.Top = pictureBox1.Top + 80;
                    pictureBox2.Left = pictureBox1.Left + 30;
                    x = 2;
                    break;
                case Keys.Left:
                    pictureBox1.Image = Image.FromFile("tank4.gif");
                    pictureBox1.Left = pictureBox1.Left - 5;
                    pictureBox2.Top = pictureBox1.Top + 20;
                    pictureBox2.Left = pictureBox1.Left - 25;
                    x = 3;
                    break;
                case Keys.Right:
                    pictureBox1.Image = Image.FromFile("tank2.gif");
                    pictureBox1.Left = pictureBox1.Left + 5;
                    pictureBox2.Top = pictureBox1.Top + 20;
                    pictureBox2.Left = pictureBox1.Left + 85;
                    x = 4;
                    break;
                case Keys.Space:
                    pictureBox2.Visible = true;
                    
                        timer1.Enabled = true;
                    break;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            timer1.Interval = 30;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                if (x == 1)
                {
                    pictureBox2.Top -= 15;
                }
                else if (x == 2)
                {
                    pictureBox2.Top += 15;
                }
                else if (x == 3)
                {
                pictureBox2.Left -= 15;
                }
                else if (x == 4)
                {
                    pictureBox2.Left += 15;
                }
            
        }
    }
}