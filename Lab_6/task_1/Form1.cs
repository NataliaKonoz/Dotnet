namespace task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] cities = { "��������", "��������", "�����", "̳������", "���", "����", "��������" };
            comboBoxCities.Items.AddRange(cities);
            listBoxCities.Items.AddRange(cities);
        }
    }
}