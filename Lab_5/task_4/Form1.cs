namespace task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            this.Text = "TextBox Example";
            this.Size = new Size(400, 200);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextBox textBox1 = new TextBox();
            textBox1.Text = "Перший рядок";
            textBox1.Font = new Font("Arial", 12, FontStyle.Bold | FontStyle.Underline);
            textBox1.ForeColor = Color.Gray;
            textBox1.BackColor = Color.Red;
            textBox1.TextAlign = HorizontalAlignment.Left;
            textBox1.Dock = DockStyle.Top;
            textBox1.ReadOnly = true;

            TextBox textBox2 = new TextBox();
            textBox2.Text = "Другий рядок";
            textBox2.Font = new Font("Arial", 13, FontStyle.Italic | FontStyle.Underline);
            textBox2.ForeColor = Color.Brown;
            textBox2.BackColor = Color.Purple;
            textBox2.TextAlign = HorizontalAlignment.Right;
            textBox2.Dock = DockStyle.Top;
            textBox2.ReadOnly = true;

            TextBox textBox3 = new TextBox();
            textBox3.Text = "Третій рядок";
            textBox3.Font = new Font("Arial", 17, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            textBox3.ForeColor = Color.Yellow;
            textBox3.BackColor = Color.Green;
            textBox3.TextAlign = HorizontalAlignment.Left;
            textBox3.Dock = DockStyle.Top;
            textBox3.ReadOnly = true;

            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
        }
    }
}
