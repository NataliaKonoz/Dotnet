namespace task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Масив міст Угорщини
            string[] cities = { "Будапешт", "Дебрецен", "Сегед", "Мішкольц", "Печ", "Дьєр", "Кечкемет" };

            // Додавання міст у ComboBox
            comboBoxCities.Items.AddRange(cities);

            // Додавання міст у ListBox
            listBoxCities.Items.AddRange(cities);
        }
    }
}