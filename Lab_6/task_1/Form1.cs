namespace task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // ����� ��� ��������
            string[] cities = { "��������", "��������", "�����", "̳������", "���", "����", "��������" };

            // ��������� ��� � ComboBox
            comboBoxCities.Items.AddRange(cities);

            // ��������� ��� � ListBox
            listBoxCities.Items.AddRange(cities);
        }
    }
}