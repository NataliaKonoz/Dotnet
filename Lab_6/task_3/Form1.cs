using System;
using System.Windows.Forms;
namespace task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            DateTime birthDate = dtpBirthDate.Value;
            MessageBox.Show($"Ім'я: {name}\nТелефон: {phone}\nПошта: {email}\nДата народження: {birthDate.ToShortDateString()}\n", "Реєстрація завершена");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            dtpBirthDate.Value = DateTime.Now;
        }
    }
}