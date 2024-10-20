namespace task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Label label1 = new Label();
            label1.Text = "Перший рядок";
            label1.Font = new Font("Arial", 12, FontStyle.Bold | FontStyle.Underline);
            label1.ForeColor = Color.Gray;
            label1.BackColor = Color.Red;
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Dock = DockStyle.Top;

            Label label2 = new Label();
            label2.Text = "Другий рядок";
            label2.Font = new Font("Arial", 13, FontStyle.Italic | FontStyle.Underline);
            label2.ForeColor = Color.Brown;
            label2.BackColor = Color.Purple;
            label2.TextAlign = ContentAlignment.MiddleRight;
            label2.Dock = DockStyle.Top;

            Label label3 = new Label();
            label3.Text = "Третій рядок";
            label3.Font = new Font("Arial", 17, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label3.ForeColor = Color.Yellow;
            label3.BackColor = Color.Green;
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Dock = DockStyle.Top;

            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);

            this.Text = "Label Example";
            this.Size = new Size(400, 200);
        }
    }
}
