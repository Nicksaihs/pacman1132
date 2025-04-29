namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // ÅÜ¼Æ°Ï°ì

        bool goup, godown, goleft, goright = false;
        int pacmanspeed = 1;
        int score = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 5;
            timer1.Enabled = Enabled;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            goup = godown = goleft = goright = false;

            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (goup)
            {
                pacman.Top -= pacmanspeed;
                pacman.Image = Properties.Resources.pacmanup;

            }
            else if (godown)
            {
                pacman.Top += pacmanspeed;
                pacman.Image = Properties.Resources.pacmandown;

            }
            else if (goleft)
            {
                pacman.Left -= pacmanspeed;
                pacman.Image = Properties.Resources.pacmanleft;

            }
            else if (goright)
            {
                pacman.Left += pacmanspeed;
                pacman.Image = Properties.Resources.pacman;

            }


            if (pacman.Bounds.IntersectsWith(pictureBox33.Bounds)) {
                if (pictureBox33.Visible)
                {
                    score += 1;
                }
                pictureBox33.Visible = false;                
            }
            if (pacman.Bounds.IntersectsWith(pictureBox32.Bounds))
            {
                if (pictureBox32.Visible)
                {
                    score += 1;
                }
                pictureBox32.Visible = false;
            }
            if (pacman.Bounds.IntersectsWith(pictureBox31.Bounds))
            {
                if (pictureBox31.Visible)
                {
                    score += 1;
                }
                pictureBox31.Visible = false;
            }
            //¸I¼²Àð¾À
            if (pacman.Bounds.IntersectsWith(panel1.Bounds))
            {
                goup = godown = goleft = goright = false;
            }

            label2.Text = "Score: " + score;
            label4.Text = "X:" + pacman.Location.X + "Y:" + pacman.Location.Y;
        }


    }
}