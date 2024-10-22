namespace task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] cities = { "Будапешт", "Дебрецен", "Сегед", "Мішкольц", "Печ", "Дьєр", "Кечкемет" };
            comboBoxCities.Items.AddRange(cities);
            listBoxCities.Items.AddRange(cities);
        }
    }
}