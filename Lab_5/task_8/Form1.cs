using System;
using System.Windows.Forms;

namespace task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load; // Підписуємося на подію завантаження форми
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeTableLayoutPanel(); // Ініціалізуємо таблицю та кнопки під час завантаження форми
        }

        private void InitializeTableLayoutPanel()
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
            {
                ColumnCount = 3,
                RowCount = 3,
                Dock = DockStyle.Fill,
                AutoSize = false,
            };

            Button button1 = new Button { Text = "Button 1", Width = 100, Height = 100, AutoSize = false, Margin = new Padding(10, 10, 0, 0) };
            Button button2 = new Button { Text = "Button 2", Width = 100, Height = 100, AutoSize = false, Margin = new Padding(100, 0, 0, 10) };
            Button button3 = new Button { Text = "Button 3", Width = 100, Height = 100, AutoSize = false, Margin = new Padding(10, 0, 0, 0) };
            Button button4 = new Button { Text = "Button 4", Width = 100, Height = 100, AutoSize = false, Margin = new Padding(400, 10, 0, 0) };
            Button button5 = new Button { Text = "Button 5", Width = 100, Height = 100, AutoSize = false, Margin = new Padding(15, 5, 0, 0) };

            tableLayoutPanel.Controls.Add(button1, 0, 0);
            tableLayoutPanel.Controls.Add(button4, 1, 0);
            tableLayoutPanel.Controls.Add(button5, 0, 1);
            tableLayoutPanel.Controls.Add(button2, 1, 1);
            tableLayoutPanel.Controls.Add(button3, 0, 2);

            this.Controls.Add(tableLayoutPanel);
        }
    }
}
