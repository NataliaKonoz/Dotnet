namespace task_1
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private PictureBox[] pictureBoxes;

        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(700, 450);
            pictureBoxes = new PictureBox[5];

            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i] = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };
                if (i == 0)
                {
                    pictureBoxes[i].Height = 50;
                    pictureBoxes[i].Width = 160;
                    pictureBoxes[i].Location = new Point(10, 10);
                }
                else if (i == 1)
                {
                    pictureBoxes[i].Height = 50;
                    pictureBoxes[i].Width = 100;
                    pictureBoxes[i].Location = new Point(180, 10);
                }
                else if (i == 2)
                {
                    pictureBoxes[i].Height = 100;
                    pictureBoxes[i].Width = 160;
                    pictureBoxes[i].Location = new Point(290, 10);
                }
                else if (i == 3)
                {
                    pictureBoxes[i].Height = 75;
                    pictureBoxes[i].Width = 100;
                    pictureBoxes[i].Location = new Point(460, 10);
                }
                else if (i == 4)
                {
                    pictureBoxes[i].Height = 100;
                    pictureBoxes[i].Width = 100;
                    pictureBoxes[i].Location = new Point(570, 10);
                }
                pictureBoxes[i].Image = Image.FromFile($"SUNSET.jfif");
                Controls.Add(pictureBoxes[i]);
            }
        }
    }
}
