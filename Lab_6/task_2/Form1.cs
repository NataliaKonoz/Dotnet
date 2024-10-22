namespace task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ComboBox comboBoxCities = new ComboBox();     //
            ListBox listBoxCities = new ListBox();        //
            string[] cities = { "Будапешт", "Дебрецен", "Сегед", "Мішкольц", "Печ", "Дьєр", "Кечкемет" };
            comboBoxCities.Items.AddRange(cities);
            comboBoxCities.Location = new System.Drawing.Point(50, 50);
            comboBoxCities.Size = new System.Drawing.Size(200, 21);
            listBoxCities.Items.AddRange(cities);
            listBoxCities.Location = new System.Drawing.Point(50, 100);
            listBoxCities.Size = new System.Drawing.Size(200, 95);
            this.Controls.Add(comboBoxCities);
            this.Controls.Add(listBoxCities);
        }
    }
}